namespace RingCentral
{
    public class HostInfoRequest : Serializable
    {
        // Internal identifier of an extension which is assigned to be a meeting host. The default value is currently logged-in extension identifier
        public string id;
    }
}