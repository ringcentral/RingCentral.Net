using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.ForwardAllCalls
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Index parent;
public Index(Restapi.Account.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/forward-all-calls";
        }
        /// <summary>
        /// Returns information about *Forward All Company Calls* feature setting.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/forward-all-calls
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyAnsweringRules
        /// </summary>
  public async Task<RingCentral.ForwardAllCompanyCallsInfo> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.ForwardAllCompanyCallsInfo>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates *Forward All Company Calls* feature setting.
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/forward-all-calls
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
        /// </summary>
  public async Task<RingCentral.ForwardAllCompanyCallsInfo> Patch(RingCentral.ForwardAllCompanyCallsRequest forwardAllCompanyCallsRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Patch<RingCentral.ForwardAllCompanyCallsInfo>(this.Path(), forwardAllCompanyCallsRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ForwardAllCalls.Index ForwardAllCalls()
        {
            return new Restapi.Account.ForwardAllCalls.Index(this);
        }
    }
}