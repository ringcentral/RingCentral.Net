namespace RingCentral
{
    public class PhoneLinesInfo
    {
        /// <summary>
        /// Internal identifier of a phone line
        /// </summary>
        public string id;

        /// <summary>
        /// Type of phone line
        /// Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType;

        /// <summary>
        /// </summary>
        public PhoneNumberInfoIntId phoneInfo;

        /// <summary>
        /// </summary>
        public EmergencyAddress emergencyAddress;
    }
}