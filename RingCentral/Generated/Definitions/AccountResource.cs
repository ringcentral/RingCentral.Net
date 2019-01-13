using Newtonsoft.Json;

namespace RingCentral
{
    public class AccountResource : Serializable
    {
        public string companyName;
        public string federatedName;
        public string id;
        public PhoneNumberResource mainNumber;
    }
}