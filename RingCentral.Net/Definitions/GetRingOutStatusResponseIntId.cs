namespace RingCentral
{
    public class GetRingOutStatusResponseIntId
    {
        /// <summary>
        ///     Internal identifier of a RingOut call
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public RingOutStatusInfo status { get; set; }
    }
}