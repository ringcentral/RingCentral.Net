using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.DataExport.Datasets
{
    public class Index
    {
        public string datasetId;
        public DataExport.Index parent;
        public RestClient rc;

        public Index(DataExport.Index parent, string datasetId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.datasetId = datasetId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && datasetId != null) return $"{parent.Path()}/datasets/{datasetId}";

            return $"{parent.Path()}/datasets";
        }

        /// <summary>
        ///     Returns the specified dataset by ID. Each dataset is a ZIP archive the size of which is limited to 1 Gb.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/data-export/{taskId}/datasets/{datasetId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: Glip
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public Datasets.Index Datasets(string datasetId = null)
        {
            return new Datasets.Index(this, datasetId);
        }
    }
}