using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.OptOuts.Export
{
    public class Index
    {
        public OptOuts.Index parent;
        public RestClient rc;

        public Index(OptOuts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/export";
        }

        /// <summary>
        ///     Returns a list of numbers that are opted out and/or opted in at the account level in CSV format.
        ///     Header row will define the following columns.
        ///     | Column name | Data type | Description |
        ///     | ----------- | --------- | ----------- |
        ///     | From        | string    | Sender phone number in E.164 or the wildcard |
        ///     | To          | string    | Recipient phone number in E.164 |
        ///     | Status      | string    | Either "OptOut" or "OptIn" |
        ///     | Source      | string    | Source of the opt record   |
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/sms/opt-outs/export
        ///     Rate Limit Group: Light
        ///     App Permission: SMS
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.OptOuts
{
    public partial class Index
    {
        public Export.Index Export()
        {
            return new Export.Index(this);
        }
    }
}