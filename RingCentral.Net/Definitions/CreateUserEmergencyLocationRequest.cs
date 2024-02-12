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
        /// </summary>
        public CommonEmergencyLocationAddressInfo address { get; set; }
    }
}