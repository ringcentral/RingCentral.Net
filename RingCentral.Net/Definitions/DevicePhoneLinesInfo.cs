namespace RingCentral
{
    public class DevicePhoneLinesInfo
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
        public DevicePhoneLinesEmergencyAddressInfo emergencyAddress;

        /// <summary>
        /// </summary>
        public DevicePhoneNumberInfo phoneInfo;
    }
}