using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ForwardAllCalls
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/forward-all-calls";
        }

        /// <summary>
        ///     Returns information about *Forward All Company Calls* feature setting.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/forward-all-calls
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<ForwardAllCompanyCallsInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ForwardAllCompanyCallsInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates *Forward All Company Calls* feature setting.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/forward-all-calls
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<ForwardAllCompanyCallsInfo> Patch(ForwardAllCompanyCallsRequest forwardAllCompanyCallsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<ForwardAllCompanyCallsInfo>(Path(), forwardAllCompanyCallsRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public ForwardAllCalls.Index ForwardAllCalls()
        {
            return new ForwardAllCalls.Index(this);
        }
    }
}