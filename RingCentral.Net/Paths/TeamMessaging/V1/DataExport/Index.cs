using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.DataExport
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string taskId;
public Index(TeamMessaging.V1.Index parent, string taskId = null)
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
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/data-export
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: Glip
        /// </summary>
  public async Task<RingCentral.DataExportTaskList> List(RingCentral.ListDataExportTasksNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.DataExportTaskList>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a task for Glip data export and returns a link at which the exported data will be available in future once the task is implemented. The exported data can be downloaded by calling Get Data Export Task method with the specified task ID. Simultaneously no more than 2 tasks per company can be created.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/data-export
        /// Rate Limit Group: Heavy
        /// App Permission: TeamMessaging
        /// User Permission: Glip
        /// </summary>
  public async Task<RingCentral.DataExportTask> Post(RingCentral.CreateDataExportTaskRequest createDataExportTaskRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.DataExportTask>(this.Path(false), createDataExportTaskRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns the links for downloading Glip data exported within the specified task. If the export task is still in progress, then only the task status will be returned. If the data is ready for downloading, then the list of URLs will be returned.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/data-export/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: Glip
        /// </summary>
  public async Task<RingCentral.DataExportTask> Get(RestRequestConfig restRequestConfig = null)
  {
if (taskId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
    }return await rc.Get<RingCentral.DataExportTask>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.DataExport.Index DataExport(string taskId = null)
        {
            return new TeamMessaging.V1.DataExport.Index(this, taskId);
        }
    }
}