using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Create Data Export Task
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/data-export
        /// Rate Limit Group: Heavy
        /// App Permission Required: Glip
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTask> Post(
            RingCentral.CreateDataExportTaskRequest createDataExportTaskRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.DataExportTask>(this.Path(false), createDataExportTaskRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get Data Export Task List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTaskList> List(ListDataExportTasksParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.DataExportTaskList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Data Export Task
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTask> Get(CancellationToken? cancellationToken = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.DataExportTask>(this.Path(), null, cancellationToken);
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