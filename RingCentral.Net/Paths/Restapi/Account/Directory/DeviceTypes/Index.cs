using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.DeviceTypes
{
    public class Index
    {
        public Directory.Index parent;
        public RestClient rc;

        public Index(Directory.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/device-types";
        }

        /// <summary>
        ///     Returns all the (distinct) type IDs of devices for particular account
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/device-types
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<DeviceTypesResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DeviceTypesResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public DeviceTypes.Index DeviceTypes()
        {
            return new DeviceTypes.Index(this);
        }
    }
}