namespace RingCentral
{
    public class GetRingOutStatusResponse
    {
        /// <summary>
        ///     Internal identifier of a RingOut call
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public RingOutStatusInfo status { get; set; }
    }
}