using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.DataExport.Datasets
{
    public partial class Index
    {
        public RestClient rc;
        public string datasetId;
        public Restapi.Glip.DataExport.Index parent;

        public Index(Restapi.Glip.DataExport.Index parent, string datasetId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.datasetId = datasetId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && datasetId != null)
            {
                return $"{parent.Path()}/datasets/{datasetId}";
            }

            return $"{parent.Path()}/datasets";
        }

        /// <summary>
        /// Operation: Get Data Export Task Dataset
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: Glip
        /// User Permission Required: undefined
        /// </summary>
        public async Task<byte[]> Get(CancellationToken? cancellationToken = null)
        {
            if (this.datasetId == null)
            {
                throw new System.ArgumentNullException("datasetId");
            }

            return await rc.Get<byte[]>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public Restapi.Glip.DataExport.Datasets.Index Datasets(string datasetId = null)
        {
            return new Restapi.Glip.DataExport.Datasets.Index(this, datasetId);
        }
    }
}