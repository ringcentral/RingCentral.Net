using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral
{
    public class BatchResponse<T>
    {
        public T content;
        public ADGErrorResponse error;
        public BatchSummary summary;
    }

    public class BatchSummary
    {
        public string href;
        public string responseDescription;
        public int status;

        public bool isError => status < 200 || status >= 300;
    }

    public class BatchSummaries
    {
        public BatchSummary[] response;
    }

    partial class RestClient
    {
        public async Task<BatchResponse<T>[]> BatchGet<T>(string endpoint, object queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            // if no multiple IDs specified
            if (!endpoint.Contains(","))
                throw new ArgumentException(
                    "In order to make a BatchGet, endpoint should contain multiple IDs delimited by ','");

            var httpResponseMessage = await Get<HttpResponseMessage>(endpoint, queryParams, restRequestConfig);
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
                    batchResponse.error = JsonConvert.DeserializeObject<ADGErrorResponse>(responseString);
                else
                    batchResponse.content = JsonConvert.DeserializeObject<T>(responseString);
            }

            return result.ToArray();
        }
    }
}