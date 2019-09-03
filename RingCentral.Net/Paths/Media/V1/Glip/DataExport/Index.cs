namespace RingCentral.Paths.Media.V1.Glip.DataExport
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Media.V1.Glip.Index parent;

        public Index(Media.V1.Glip.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/data-export/{taskId}";
            }

            return $"{parent.Path()}/data-export";
        }
    }
}

namespace RingCentral.Paths.Media.V1.Glip
{
    public partial class Index
    {
        public Media.V1.Glip.DataExport.Index DataExport(string taskId = null)
        {
            return new Media.V1.Glip.DataExport.Index(this, taskId);
        }
    }
}