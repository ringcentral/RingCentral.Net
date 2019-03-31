namespace RingCentral
{
    public class GetRingOutStatusResponseIntId
    {
        /* Internal identifier of a RingOut call */
        public long? id;

        public string uri;

        /* RingOut status information */
        public RingOutStatusInfo status;
    }
}