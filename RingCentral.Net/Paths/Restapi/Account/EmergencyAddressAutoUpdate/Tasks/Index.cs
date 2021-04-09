using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Tasks
{
    public class Index
    {
        public EmergencyAddressAutoUpdate.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(EmergencyAddressAutoUpdate.Index parent, string taskId = null)
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
        ///     Returns results of the task created within the frame of Automatic Location Updates feature. Currently four task
        ///     types are supported: 'Wireless Points Bulk Create', 'Wireless Points Bulk Update', 'Switches Bulk Create',
        ///     'Switches Bulk Update'.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/tasks/{taskId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<AutomaticLocationUpdatesTaskInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AutomaticLocationUpdatesTaskInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Tasks.Index Tasks(string taskId = null)
        {
            return new Tasks.Index(this, taskId);
        }
    }
}