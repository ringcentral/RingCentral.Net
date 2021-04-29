using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string deviceId;

        public Index(Restapi.Account.Index parent, string deviceId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.deviceId = deviceId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null)
            {
                return $"{parent.Path()}/device/{deviceId}";
            }

            return $"{parent.Path()}/device";
        }

        /// <summary>
        /// Returns account device(s) by their ID(s).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<RingCentral.GetDeviceInfoResponse> Get(RingCentral.ReadDeviceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetDeviceInfoResponse>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Updates account device(s) by their ID(s).
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyDevices
        /// </summary>
        public async Task<RingCentral.GetDeviceInfoResponse> Put(RingCentral.AccountDeviceUpdate accountDeviceUpdate,
            RingCentral.UpdateDeviceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.GetDeviceInfoResponse>(this.Path(), accountDeviceUpdate, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Device.Index Device(string deviceId = null)
        {
            return new Restapi.Account.Device.Index(this, deviceId);
        }
    }
}