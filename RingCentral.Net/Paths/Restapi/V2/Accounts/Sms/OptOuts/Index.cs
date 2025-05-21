using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.OptOuts
{
    public partial class Index
    {
        public Sms.Index parent;
        public RestClient rc;

        public Index(Sms.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/opt-outs";
        }

        /// <summary>
        ///     Returns a list of records with phone numbers that are opted out and/or opted-in for SMS
        ///     at the account level. The list can be filtered by `to`/`from` phone number query parameters.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/opt-outs
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<OptRecordList> Get(ListSmsOptRecordsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<OptRecordList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the opted out/in numbers.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/opt-outs
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<OptRecordsModificationSummary> Delete(DeleteOptRecordList deleteOptRecordList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<OptRecordsModificationSummary>(Path(), deleteOptRecordList, null, restRequestConfig);
        }

        /// <summary>
        ///     Adds or updates the opted out/in numbers.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/opt-outs
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<OptRecordsModificationSummary> Patch(UpdateOptRecordList updateOptRecordList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<OptRecordsModificationSummary>(Path(), updateOptRecordList, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms
{
    public partial class Index
    {
        public OptOuts.Index OptOuts()
        {
            return new OptOuts.Index(this);
        }
    }
}