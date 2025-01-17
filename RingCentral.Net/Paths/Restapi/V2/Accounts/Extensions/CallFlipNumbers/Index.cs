using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CallFlipNumbers
{
    public class Index
    {
        public Extensions.Index parent;
        public RestClient rc;

        public Index(Extensions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-flip-numbers";
        }

        /// <summary>
        ///     Returns call flip settings. Call flip destination is an extension level setting.
        ///     The following numbers can be used for call flip:
        ///     * User's DL numbers (added/removed automatically by the System)
        ///     * PSTN numbers in E.164 format (added/removed manually by User)
        ///     Call flip list is generally limited up to 10 numbers.
        ///     **Please note:** This API is only working with the new Communication Handling flow.
        ///     To ensure that please check if the 'NewCallHandlingAndForwarding' feature is supported.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/call-flip-numbers
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CallFlipNumberListResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallFlipNumberListResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates call flip settings. Call flip destination is an extension level setting.
        ///     The following numbers can be used for call flip:
        ///     * User's DL numbers (added/removed automatically by the System)
        ///     * PSTN numbers in E.164 format (added/removed manually by User)
        ///     Call flip list is generally limited up to 10 numbers.
        ///     **Please note:** This API is only working with the new Communication Handling flow.
        ///     To ensure that please check if the 'NewCallHandlingAndForwarding' feature is supported.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/call-flip-numbers
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<CallFlipNumberListResource> Put(
            CallFlipNumberListResource callFlipNumberListResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CallFlipNumberListResource>(Path(), callFlipNumberListResource, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public CallFlipNumbers.Index CallFlipNumbers()
        {
            return new CallFlipNumbers.Index(this);
        }
    }
}