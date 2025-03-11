using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Grant
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/grant";
        }

        /// <summary>
        ///     Returns a list of extensions including information on grants given to the current extension towards them.
        ///     Currently the list of grants includes: picking up a call, call monitoring, calling or receiving a call on behalf
        ///     of somebody, call delegation and calling paging groups.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/grant
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<GetExtensionGrantListResponse> Get(ListExtensionGrantsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetExtensionGrantListResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Grant.Index Grant()
        {
            return new Grant.Index(this);
        }
    }
}