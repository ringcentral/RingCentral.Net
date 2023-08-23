namespace RingCentral
{
    public class CreateUserEmergencyLocationRequest
    {
        /// <summary>
        ///     Name of a new personal emergency response location
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Address format id
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        /// </summary>
        public CreateUserEmergencyLocationRequestAddress address { get; set; }
    }
}