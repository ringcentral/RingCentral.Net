using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
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
            return $"{parent.Path()}/consents";
        }

        /// <summary>
        ///     Returns a list of account-level SMS consent records for opted-out and/or opted-in phone numbers.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/consents
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<OptRecordList> Get(ListSmsConsentRecordsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<OptRecordList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes SMS consent records.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/consents
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<OptRecordsModificationSummary> Delete(DeleteOptRecordList deleteOptRecordList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<OptRecordsModificationSummary>(Path(), deleteOptRecordList, null, restRequestConfig);
        }

        /// <summary>
        ///     Adds or updates SMS consent records.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/consents
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
        public Consents.Index Consents()
        {
            return new Consents.Index(this);
        }
    }
}