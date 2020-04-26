using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral
{
    public class BatchResponse<T>
    {
        public BatchSummary summary;
        public ErrorResponse error;
        public T content;
    }

    public class BatchSummary
    {
        public string href;
        public int status;
        public string responseDescription;

        public bool isError => status < 200 || status >= 300;
    }

    public class BatchSummaries
    {
        public BatchSummary[] response;
    }

    partial class RestClient
    {
        public async Task<BatchResponse<T>[]> BatchGet<T>(string endpoint, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            // if no multiple IDs specified
            if (!endpoint.Split(new char[] {'/'}).Any(t => t.Contains(",")))
            {
                throw new ArgumentException(
                    "In order to make a batchGet, endpoint should contain multiple IDs delimited by ','");
            }

            var httpResponseMessage = await Get<HttpResponseMessage>(endpoint, queryParams, cancellationToken);
            var multipart = await httpResponseMessage.Content.ReadAsMultipartAsync();
            var summariesString = await multipart.Contents.First().ReadAsStringAsync();
            var batchSummaries = JsonConvert.DeserializeObject<BatchSummaries>(summariesString);
            var result = new List<BatchResponse<T>>();
            for (var i = 0; i < batchSummaries.response.Length; i++)
            {
                var batchSummary = batchSummaries.response[i];
                var batchResponse = new BatchResponse<T> {summary = batchSummary};
                result.Add(batchResponse);
                var responseString = await multipart.Contents[i + 1].ReadAsStringAsync();
                if (batchSummary.isError)
                {
                    batchResponse.error = JsonConvert.DeserializeObject<ErrorResponse>(responseString);
                }
                else
                {
                    batchResponse.content = JsonConvert.DeserializeObject<T>(responseString);
                }
            }

            return result.ToArray();
        }
    }
}