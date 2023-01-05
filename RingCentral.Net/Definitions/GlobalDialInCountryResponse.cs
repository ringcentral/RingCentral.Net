namespace RingCentral
{
    public class GlobalDialInCountryResponse
    {
        /// <summary>
        /// </summary>
        public string countryCode { get; set; }

        /// <summary>
        /// </summary>
        public string countryName { get; set; }

        /// <summary>
        /// </summary>
        public bool? @checked { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? order { get; set; }
    }
}