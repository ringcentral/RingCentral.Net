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

        /// <summary>
        /// Returns the list of Glip data export tasks.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTaskList> List(ListDataExportTasksParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.DataExportTaskList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a task for Glip data export and returns a link at which the exported data will be available in future once the task is implemented. The exported data can be downloaded by calling Get Data Export Task method with the specified task ID. Simultaneously no more than 2 tasks per company can be created.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/data-export
        /// Rate Limit Group: Heavy
        /// App Permission: Glip
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTask> Post(
            RingCentral.CreateDataExportTaskRequest createDataExportTaskRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.DataExportTask>(this.Path(false), createDataExportTaskRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns the links for downloading Glip data exported within the specified task. If the export task is still in progress, then only the task status will be returned. If the data is ready for downloading, then the list of URLs will be returned.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DataExportTask> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.DataExportTask>(this.Path(), null, restRequestConfig);
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