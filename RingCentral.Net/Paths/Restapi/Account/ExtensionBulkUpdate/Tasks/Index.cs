using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.ExtensionBulkUpdate.Index parent;
        public string taskId;

        public Index(Restapi.Account.ExtensionBulkUpdate.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/tasks/{taskId}";
            }

            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        /// Returns the status of multiple extension update task
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension-bulk-update/tasks/{taskId}
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: EditExtensionInfo
        /// </summary>
        public async Task<RingCentral.ExtensionBulkUpdateTaskResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ExtensionBulkUpdateTaskResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate
{
    public partial class Index
    {
        public Restapi.Account.ExtensionBulkUpdate.Tasks.Index Tasks(string taskId = null)
        {
            return new Restapi.Account.ExtensionBulkUpdate.Tasks.Index(this, taskId);
        }
    }
}