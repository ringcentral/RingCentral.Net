namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public Glip.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(Glip.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/data-export/{taskId}";
            return $"{parent.Path()}/data-export";
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public DataExport.Index DataExport(string taskId = null)
        {
            return new DataExport.Index(this, taskId);
        }
    }
}