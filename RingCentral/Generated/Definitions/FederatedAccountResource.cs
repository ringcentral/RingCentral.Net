using Newtonsoft.Json;

namespace RingCentral
{
    public class FederatedAccountResource : Serializable
    {
        public string companyName;
        public int? conflictCount;
        public string federatedName;
        public string id;
        public string linkCreationTime;
        public PhoneNumberResource mainNumber;
    }
}