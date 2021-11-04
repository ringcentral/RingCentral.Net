using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public string groupId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string groupId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null) return $"{parent.Path()}/call-monitoring-groups/{groupId}";

            return $"{parent.Path()}/call-monitoring-groups";
        }

        /// <summary>
        ///     Returns call monitoring groups that can be filtered by some extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroups> Get(
            ListCallMonitoringGroupsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroups>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new call monitoring group.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: Groups
        /// </summary>
        public async Task<CallMonitoringGroup> Post(
            CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallMonitoringGroup>(Path(false), createCallMonitoringGroupRequest,
                null, restRequestConfig);
        }

        /// <summary>
        ///     Updates call monitoring group name by ID.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: Groups
        /// </summary>
        public async Task<CallMonitoringGroup> Put(
            CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null) throw new ArgumentException("Parameter cannot be null", nameof(groupId));

            return await rc.Put<CallMonitoringGroup>(Path(), createCallMonitoringGroupRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Removes information about the given call monitoring group.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: Groups
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null) throw new ArgumentException("Parameter cannot be null", nameof(groupId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallMonitoringGroups.Index CallMonitoringGroups(string groupId = null)
        {
            return new CallMonitoringGroups.Index(this, groupId);
        }
    }
}