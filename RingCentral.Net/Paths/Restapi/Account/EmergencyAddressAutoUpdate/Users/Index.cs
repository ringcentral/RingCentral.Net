using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users
{
    public partial class Index
    {
        public EmergencyAddressAutoUpdate.Index parent;
        public RestClient rc;

        public Index(EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/users";
        }

        /// <summary>
        ///     Returns a list of users with their status of Automatic Location
        ///     Updates feature.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<AutomaticLocationUpdatesUserList> Get(
            ListAutomaticLocationUpdatesUsersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AutomaticLocationUpdatesUserList>(Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Users.Index Users()
        {
            return new Users.Index(this);
        }
    }
}