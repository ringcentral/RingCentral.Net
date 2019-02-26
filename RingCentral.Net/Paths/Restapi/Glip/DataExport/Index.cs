using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string taskId = null)
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

        // Operation: createDataExportTask
        public async Task<RingCentral.DataExportTask> Post(
            RingCentral.CreateDataExportTaskRequest createDataExportTaskRequest)
        {
            return await rc.Post<RingCentral.DataExportTask>(this.Path(false), createDataExportTaskRequest);
        }

        // Operation: loadDataExportTask
        public async Task<RingCentral.DataExportTask> Get()
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.DataExportTask>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.DataExport.Index DataExport(string taskId = null)
        {
            return new Restapi.Glip.DataExport.Index(this, taskId);
        }
    }
}