namespace RingCentral
{
    public class DevicePhoneLinesInfo
    {
        /// <summary>
        /// Type of phone line
        /// Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType;

        /// <summary>
        /// </summary>
        public DevicePhoneLinesEmergencyAddressInfo emergencyAddress;

        /// <summary>
        /// Phone number information
        /// </summary>
        public DevicePhoneNumberInfo phoneInfo;
    }
}