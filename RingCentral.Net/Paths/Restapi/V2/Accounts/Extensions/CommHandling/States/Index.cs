using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.States
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.Extensions.CommHandling.Index parent;
        public string stateId;
        public Index(Restapi.V2.Accounts.Extensions.CommHandling.Index parent, string stateId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.stateId = stateId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && stateId != null)
            {
                return $"{parent.Path()}/states/{stateId}";
            }
            return $"{parent.Path()}/states";
        }
        /// <summary>
        /// Returns a list of communication handling states.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.CommStatesResource> List(RingCentral.ListCicStatesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CommStatesResource>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns a communication handling state.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states/{stateId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.CommStateResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(stateId));
            }
            return await rc.Get<RingCentral.CommStateResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a communication handling state condition.
        /// HTTP Method: patch
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/states/{stateId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.CommStateResource> Patch(RingCentral.CommStateUpdateRequest commStateUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(stateId));
            }
            return await rc.Patch<RingCentral.CommStateResource>(this.Path(), commStateUpdateRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.CommHandling.States.Index States(string stateId = null)
        {
            return new Restapi.V2.Accounts.Extensions.CommHandling.States.Index(this, stateId);
        }
    }
}