namespace RingCentral
{
    public class FederatedAccountResource : Serializable
    {
        public string companyName;
        public long? conflictCount;
        public string federatedName;
        public string id;
        public string linkCreationTime;
        public PhoneNumberResource mainNumber;
    }
}