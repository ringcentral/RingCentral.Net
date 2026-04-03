namespace RingCentral
{
    public class PhoneLinesInfo
    {
        /// <summary>
        ///     Internal identifier of a phone line
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     The type of phone line
        ///     Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberInfoIntId phoneInfo { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddress emergencyAddress { get; set; }
    }
}