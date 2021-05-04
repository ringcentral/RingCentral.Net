using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.AddressBookBulkUpload.Index parent;
        public string taskId;

        public Index(Restapi.Account.AddressBookBulkUpload.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/tasks/{taskId}";
            }

            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        /// Returns the status of a task on adding multiple contacts to multiple extensions.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload/tasks/{taskId}
        /// Rate Limit Group: Light
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.AddressBookBulkUploadResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
            }

            return await rc.Get<RingCentral.AddressBookBulkUploadResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.AddressBookBulkUpload
{
    public partial class Index
    {
        public Restapi.Account.AddressBookBulkUpload.Tasks.Index Tasks(string taskId = null)
        {
            return new Restapi.Account.AddressBookBulkUpload.Tasks.Index(this, taskId);
        }
    }
}