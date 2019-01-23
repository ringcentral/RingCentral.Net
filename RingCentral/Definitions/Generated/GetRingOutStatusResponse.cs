namespace RingCentral
{
    public class GetRingOutStatusResponse : Serializable
    {
        // Internal identifier of a RingOut call
        public string id;
        public string uri;
        // RingOut status information
        public RingOutStatusInfo status;
    }
}