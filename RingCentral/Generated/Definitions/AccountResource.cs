using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AccountResource : Serializable
    {
        public string companyName;
        public string federatedName;
        public string id;
        public PhoneNumberResource mainNumber;
    }
}