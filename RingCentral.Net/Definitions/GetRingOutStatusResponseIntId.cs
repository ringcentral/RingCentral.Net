namespace RingCentral
{
    public class GetRingOutStatusResponseIntId
    {
        /// <summary>
        /// Internal identifier of a RingOut call
        /// </summary>
        public long? id;

        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// RingOut status information
        /// </summary>
        public RingOutStatusInfo status;
    }
}