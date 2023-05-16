using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.ForwardedNumbers
{
    public class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/forwarded-numbers";
        }

        /// <summary>
        ///     Adds forwarded numbers to an account.
        ///     **Flow #1. For Partners with their own number pool.**
        ///     Adds forwarded (ported) phone number(s) in provisioned (activated) state,
        ///     but the Partner is responsible for all further calls on behalf of this number from fraud perspective.
        ///     If extension is specified in request body then the number will be added
        ///     at extension level as `ForwardedNumber`. If extension is not specified in request,
        ///     a number is assigned directly to an account as `ForwardedCompanyNumber`.
        ///     A forwarded number can be used as an outbound caller ID.
        ///     Once a number is finally ported it turns into ordinary (not forwarded) account/extension phone number.
        ///     **Flow #2. For Partners with RingCentral-managed number pool.**
        ///     Adds forwarded (ported) phone number(s) in non-activated state. A forwarded number should be activated
        ///     via separated RC support flow.
        ///     If extension is specified in request body then the number will be added
        ///     at extension level as `ForwardedNumber`. If extension is not specified in request,
        ///     a number is assigned directly to an account as `ForwardedCompanyNumber`.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/forwarded-numbers
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<AddForwardedNumbersResponse> Post(AddForwardedNumbersRequest addForwardedNumbersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AddForwardedNumbersResponse>(Path(), addForwardedNumbersRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public ForwardedNumbers.Index ForwardedNumbers()
        {
            return new ForwardedNumbers.Index(this);
        }
    }
}