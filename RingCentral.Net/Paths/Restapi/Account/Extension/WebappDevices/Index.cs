using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.WebappDevices
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
            return $"{parent.Path()}/webapp-devices";
        }
        /// <summary>
        /// Returns the list of Web Phone (RC App) devices of the specified user extension,
        /// and their current registration status (`Online`/`Offline`).
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/webapp-devices
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.WebAppDevicesResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.WebAppDevicesResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.WebappDevices.Index WebappDevices()
        {
            return new Restapi.Account.Extension.WebappDevices.Index(this);
        }
    }
}