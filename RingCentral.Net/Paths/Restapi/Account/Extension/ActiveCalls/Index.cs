using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ActiveCalls
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/active-calls";
        }

        /// <summary>
        ///     Returns records of all extension calls that are in progress, ordered
        ///     by start time in descending order.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/active-calls
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<CallLogResponse> Get(ListExtensionActiveCallsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallLogResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public ActiveCalls.Index ActiveCalls()
        {
            return new ActiveCalls.Index(this);
        }
    }
}