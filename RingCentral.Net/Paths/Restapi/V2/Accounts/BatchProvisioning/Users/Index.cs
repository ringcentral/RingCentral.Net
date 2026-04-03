using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning.Users
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.BatchProvisioning.Index parent;
        public Index(Restapi.V2.Accounts.BatchProvisioning.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/users";
        }
        /// <summary>
        /// Creates multiple user extensions with BYOD (customer provided) devices.
        /// If "extensionNumber" is not specified, the next available extension number will be assigned.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/batch-provisioning/users
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.BatchProvisionUsersResponse> Post(RingCentral.BatchProvisionUsersRequest batchProvisionUsersRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.BatchProvisionUsersResponse>(this.Path(), batchProvisionUsersRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning
{
    public partial class Index
    {
        public Restapi.V2.Accounts.BatchProvisioning.Users.Index Users()
        {
            return new Restapi.V2.Accounts.BatchProvisioning.Users.Index(this);
        }
    }
}