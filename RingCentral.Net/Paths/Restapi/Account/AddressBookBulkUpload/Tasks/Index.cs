using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload.Tasks
{
    public class Index
    {
        public AddressBookBulkUpload.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(AddressBookBulkUpload.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/tasks/{taskId}";
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        ///     Returns the status of a task on adding multiple contacts to multiple extensions.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload/tasks/{taskId}
        ///     Rate Limit Group: Light
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<AddressBookBulkUploadResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AddressBookBulkUploadResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload
{
    public partial class Index
    {
        public Tasks.Index Tasks(string taskId = null)
        {
            return new Tasks.Index(this, taskId);
        }
    }
}