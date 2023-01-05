using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate.Tasks
{
    public class Index
    {
        public ExtensionBulkUpdate.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(ExtensionBulkUpdate.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/tasks/{taskId}";
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        ///     Returns a status of a task to update multiple extensions.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension-bulk-update/tasks/{taskId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditExtensions
        ///     User Permission: EditExtensionInfo
        /// </summary>
        public async Task<ExtensionBulkUpdateTaskResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));
            return await rc.Get<ExtensionBulkUpdateTaskResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate
{
    public partial class Index
    {
        public Tasks.Index Tasks(string taskId = null)
        {
            return new Tasks.Index(this, taskId);
        }
    }
}