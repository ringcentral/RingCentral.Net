namespace RingCentral
{
    /// <summary>
    ///     Brief information on a phone number country
    /// </summary>
    public class DevicePhoneNumberCountryInfo
    {
        /// <summary>
        ///     Internal identifier of a home country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a home country
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Official name of a home country
        /// </summary>
        public string name { get; set; }
    }
}