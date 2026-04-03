using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Grant
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/grant";
        }
        /// <summary>
        /// Returns a list of extensions including information on grants given to the current extension towards them.
        /// Currently the list of grants includes: picking up a call, call monitoring, calling or receiving a call on behalf
        /// of somebody, call delegation and calling paging groups.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/grant
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensionGrant
        /// </summary>
        public async Task<RingCentral.GetExtensionGrantListResponse> Get(RingCentral.ListExtensionGrantsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetExtensionGrantListResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Grant.Index Grant()
        {
            return new Restapi.Account.Extension.Grant.Index(this);
        }
    }
}