namespace RingCentral
{
    public class PhoneLineResource
    {
        /// <summary>
        /// Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary, BLF
        /// </summary>
        public string lineType;

        /// <summary>
        /// </summary>
        public PhoneNumberResourceIntId phoneInfo;

        /// <summary>
        /// </summary>
        public EmergencyAddress emergencyAddress;
    }
}