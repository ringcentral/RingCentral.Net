using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string groupId;

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
        /// Returns call monitoring groups that can be filtered by some extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroups> Get(
            RingCentral.ListCallMonitoringGroupsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroups>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new call monitoring group.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups
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
        /// Updates call monitoring group name by ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroup> Put(
            RingCentral.CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(groupId));
            }

            return await rc.Put<RingCentral.CallMonitoringGroup>(this.Path(), createCallMonitoringGroupRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Removes information about the given call monitoring group.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(groupId));
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