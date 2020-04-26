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
        public ErrorResponse errorResponse;
        public T normalResponse;
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
            // todo: what if only one id?

            var httpResponseMessage = await Get<HttpResponseMessage>(endpoint, queryParams, cancellationToken);
            var multipart = await httpResponseMessage.Content.ReadAsMultipartAsync();
            var batchSummaries =
                JsonConvert.DeserializeObject<BatchSummaries>(await multipart.Contents.First().ReadAsStringAsync());

            var result = new List<BatchResponse<T>>();
            var index = 0;
            foreach (var batchSummary in batchSummaries.response)
            {
                index += 1;
                var batchResponse = new BatchResponse<T> {summary = batchSummary};
                if (batchSummary.isError)
                {
                    batchResponse.errorResponse =
                        JsonConvert.DeserializeObject<ErrorResponse>(
                            await multipart.Contents[index].ReadAsStringAsync());
                }
                else
                {
                    batchResponse.normalResponse =
                        JsonConvert.DeserializeObject<T>(await multipart.Contents[index].ReadAsStringAsync());
                }

                result.Add(batchResponse);
            }

            return result.ToArray();
        }
    }
}