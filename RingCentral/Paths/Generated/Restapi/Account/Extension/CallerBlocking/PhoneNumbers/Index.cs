using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public partial class Index
    {
        public RestClient rc;
        public string blockedNumberId;
        public Restapi.Account.Extension.CallerBlocking.Index parent;

        public Index(Restapi.Account.Extension.CallerBlocking.Index parent, string blockedNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.blockedNumberId = blockedNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && blockedNumberId != null)
            {
                return $"{parent.Path()}/phone-numbers/{blockedNumberId}";
            }

            return $"{parent.Path()}/phone-numbers";
        }

        public class ListQueryParams
        {
            public string page;

            public string perPage;

            // Enum: Blocked, Allowed
            public string status;
        }

        public async Task<RingCentral.BlockedAllowedPhoneNumbersList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.BlockedAllowedPhoneNumbersList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Post(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber)
        {
            return await rc.Post<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(false),
                addBlockedAllowedPhoneNumber);
        }

        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Get()
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Get<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path());
        }

        public async Task<string> Delete()
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Delete<string>(this.Path());
        }

        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Put(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber)
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Put<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), addBlockedAllowedPhoneNumber);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index PhoneNumbers(string blockedNumberId = null)
        {
            return new Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index(this, blockedNumberId);
        }
    }
}