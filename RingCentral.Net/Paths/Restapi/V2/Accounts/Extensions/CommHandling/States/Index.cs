using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.States
{
    public class Index
    {
        public CommHandling.Index parent;
        public RestClient rc;
        public string stateId;

        public Index(CommHandling.Index parent, string stateId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.stateId = stateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && stateId != null) return $"{parent.Path()}/states/{stateId}";
            return $"{parent.Path()}/states";
        }

        /// <summary>
        ///     Returns a list of communication handling states.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommStatesResource> List(ListCicStatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CommStatesResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns a communication handling state.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states/{stateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommStateResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null) throw new ArgumentException("Parameter cannot be null", nameof(stateId));
            return await rc.Get<CommStateResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a communication handling state condition.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states/{stateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommStateResource> Patch(CommStateUpdateRequest commStateUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null) throw new ArgumentException("Parameter cannot be null", nameof(stateId));
            return await rc.Patch<CommStateResource>(Path(), commStateUpdateRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling
{
    public partial class Index
    {
        public States.Index States(string stateId = null)
        {
            return new States.Index(this, stateId);
        }
    }
}