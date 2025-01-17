using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ActiveCalls
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
            return $"{parent.Path()}/active-calls";
        }

        /// <summary>
        ///     Returns records of all calls that are in progress, ordered by start time in descending order.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/active-calls
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<CallLogResponse> Get(
            ListCompanyActiveCallsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallLogResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public ActiveCalls.Index ActiveCalls()
        {
            return new ActiveCalls.Index(this);
        }
    }
}