using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers.BulkUpdate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index parent;

        public Index(Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-update";
        }

        // Operation: createBlockedAllowedPhoneNumberLists
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.PhoneNumbers.BulkUpdate.Index BulkUpdate()
        {
            return new Restapi.Account.Extension.CallerBlocking.PhoneNumbers.BulkUpdate.Index(this);
        }
    }
}