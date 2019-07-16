using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.DataExport.Archive
{
    public partial class Index
    {
        public RestClient rc;
        public string archiveId;
        public Restapi.Glip.DataExport.Index parent;

        public Index(Restapi.Glip.DataExport.Index parent, string archiveId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.archiveId = archiveId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && archiveId != null)
            {
                return $"{parent.Path()}/archive/{archiveId}";
            }

            return $"{parent.Path()}/archive";
        }

        /// <summary>
        /// Operation: Get Glip Data Archive
        /// Http Get /restapi/v1.0/glip/data-export/{taskId}/archive/{archiveId}
        /// </summary>
        public async Task<byte[]> Get()
        {
            if (this.archiveId == null)
            {
                throw new System.ArgumentNullException("archiveId");
            }

            return await rc.Get<byte[]>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public Restapi.Glip.DataExport.Archive.Index Archive(string archiveId = null)
        {
            return new Restapi.Glip.DataExport.Archive.Index(this, archiveId);
        }
    }
}