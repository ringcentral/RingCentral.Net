namespace RingCentral
{
    public class FederationResource : Serializable
    {
        public FederatedAccountResource[] accounts;
        public string creationTime;
        public string displayName;
        public string id;
        public string lastModifiedTime;
    }
}