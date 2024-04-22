namespace RingCentral
{
    public class CreateUserEmergencyLocationRequest
    {
        /// <summary>
        ///     Name of a new personal emergency response location
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     If 'true' address validation for non-us addresses is skipped
        /// </summary>
        public bool? trusted { get; set; }

        /// <summary>
        /// </summary>
        public CommonEmergencyLocationAddressInfo address { get; set; }
    }
}