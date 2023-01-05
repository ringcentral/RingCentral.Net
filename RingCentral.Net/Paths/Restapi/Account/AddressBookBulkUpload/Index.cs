using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/address-book-bulk-upload";
        }

        /// <summary>
        ///     Uploads multiple contacts for multiple extensions at once.
        ///     Maximum 500 extensions can be uploaded per request. Max amount
        ///     of contacts that can be uploaded per extension is 10,000.
        ///     Each contact uploaded for a certain extension is not visible
        ///     to other extensions.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload
        ///     Rate Limit Group: Heavy
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<AddressBookBulkUploadResponse> Post(AddressBookBulkUploadRequest addressBookBulkUploadRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AddressBookBulkUploadResponse>(Path(), addressBookBulkUploadRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public AddressBookBulkUpload.Index AddressBookBulkUpload()
        {
            return new AddressBookBulkUpload.Index(this);
        }
    }
}