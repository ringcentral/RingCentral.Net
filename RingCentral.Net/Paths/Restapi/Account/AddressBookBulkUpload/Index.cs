using System.Threading.Tasks;

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
        /// Operation: Update Multiple Contacts
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/address-book-bulk-upload
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