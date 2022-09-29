using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Devices.Search
{
    public class Index
    {
        public Devices.Index parent;
        public RestClient rc;

        public Index(Devices.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/search";
        }

        /// <summary>
        ///     Returns a list of devices by requested search.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/devices/search
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<DevicesPaginationResource> Post(DevicesSearch devicesSearch,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<DevicesPaginationResource>(Path(), devicesSearch, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory.Devices
{
    public partial class Index
    {
        public Search.Index Search()
        {
            return new Search.Index(this);
        }
    }
}