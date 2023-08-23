using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning.Users
{
    public class Index
    {
        public BatchProvisioning.Index parent;
        public RestClient rc;

        public Index(BatchProvisioning.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/users";
        }

        /// <summary>
        ///     Creates multiple user extensions with BYOD (customer provided) devices.
        ///     If "extensionNumber" is not specified, the next available extension number will be assigned.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/batch-provisioning/users
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<BatchProvisionUsersResponse> Post(BatchProvisionUsersRequest batchProvisionUsersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<BatchProvisionUsersResponse>(Path(), batchProvisionUsersRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning
{
    public partial class Index
    {
        public Users.Index Users()
        {
            return new Users.Index(this);
        }
    }
}