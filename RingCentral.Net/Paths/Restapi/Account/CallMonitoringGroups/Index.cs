using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public RestClient rc;
        public string groupId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string groupId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null)
            {
                return $"{parent.Path()}/call-monitoring-groups/{groupId}";
            }

            return $"{parent.Path()}/call-monitoring-groups";
        }

        /// <summary>
        /// Operation: Create Call Monitoring Group
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-monitoring-groups
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroup> Post(
            RingCentral.CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallMonitoringGroup>(this.Path(false), createCallMonitoringGroupRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Call Monitoring Groups List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-monitoring-groups
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroups> Get(ListCallMonitoringGroupsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroups>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Updates Call Monitoring Group
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroup> Put(
            RingCentral.CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Put<RingCentral.CallMonitoringGroup>(this.Path(), createCallMonitoringGroupRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Call Monitoring Group
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallMonitoringGroups.Index CallMonitoringGroups(string groupId = null)
        {
            return new Restapi.Account.CallMonitoringGroups.Index(this, groupId);
        }
    }
}