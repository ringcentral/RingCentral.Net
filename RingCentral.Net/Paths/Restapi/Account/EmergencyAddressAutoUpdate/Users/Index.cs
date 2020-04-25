using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/users";
        }

        /// <summary>
        /// Operation: Get User List
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/users
        /// </summary>
        public async Task<RingCentral.AutomaticLocationUpdatesUserList> Get(
            ListAutomaticLocationUpdatesUsersParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AutomaticLocationUpdatesUserList>(this.Path(), queryParams,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Users.Index Users()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Users.Index(this);
        }
    }
}