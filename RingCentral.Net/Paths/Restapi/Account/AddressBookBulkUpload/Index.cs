using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/address-book-bulk-upload";
        }

        /// <summary>
        /// Uploads multiple contacts for multiple extensions at once. Maximum 500 extension, each up to 10000 contacts, can be updated per request.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.AddressBookBulkUploadResponse> Post(
            RingCentral.AddressBookBulkUploadRequest addressBookBulkUploadRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.AddressBookBulkUploadResponse>(this.Path(), addressBookBulkUploadRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.AddressBookBulkUpload.Index AddressBookBulkUpload()
        {
            return new Restapi.Account.AddressBookBulkUpload.Index(this);
        }
    }
}