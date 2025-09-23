using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents.Export
{
    public class Index
    {
        public Consents.Index parent;
        public RestClient rc;

        public Index(Consents.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/export";
        }

        /// <summary>
        ///     Returns a list of account-level SMS consent records for opted-out and/or opted-in phone numbers in CSV format.
        ///     The following columns will be included in the resulted CSV file:
        ///     | Column name | Data type | Description |
        ///     | ----------- | --------- | ----------- |
        ///     | From        | string    | The sender's phone number in E.164 format |
        ///     | To          | string    | The recipient's phone number in E.164 format |
        ///     | Status      | string    | The consent status, either "OptOut" or "OptIn" |
        ///     | Source      | string    | The source of the consent record |
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/consents/export
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
{
    public partial class Index
    {
        public Export.Index Export()
        {
            return new Export.Index(this);
        }
    }
}