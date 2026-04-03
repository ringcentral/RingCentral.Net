namespace RingCentral
{
    public class GetRingOutStatusResponse
    {
        /// <summary>
        ///     Internal identifier of a RingOut call
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a RingOut call resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public RingOutStatusInfo status { get; set; }
    }
}