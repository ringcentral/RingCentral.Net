using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.OptOuts.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Adds multiple opt-outs and/or opt-ins for the specified sender number and a set of recipient numbers.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/opt-outs/bulk-assign
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<OptOutBulkAssignResponse> Post(OptOutBulkAssignRequest optOutBulkAssignRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<OptOutBulkAssignResponse>(Path(), optOutBulkAssignRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms.OptOuts
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}