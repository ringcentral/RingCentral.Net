using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign
{
    public class Index
    {
        public Users.Index parent;
        public RestClient rc;

        public Index(Users.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Enables or disables Automatic Location Updates feature for multiple account users.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Post(BulkAssignAutomaticLocationUpdatesUsers bulkAssignAutomaticLocationUpdatesUsers,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), bulkAssignAutomaticLocationUpdatesUsers, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}