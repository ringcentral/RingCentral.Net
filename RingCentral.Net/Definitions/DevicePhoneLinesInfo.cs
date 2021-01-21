namespace RingCentral
{
    public class DevicePhoneLinesInfo
    {
        /// <summary>
        /// Internal identifier of a phone line
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of phone line
        /// Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType { get; set; }

        /// <summary>
        /// </summary>
        public DevicePhoneLinesEmergencyAddressInfo emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public DevicePhoneNumberInfo phoneInfo { get; set; }
    }
}