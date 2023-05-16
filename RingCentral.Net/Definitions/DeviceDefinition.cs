namespace RingCentral
{
    public class DeviceDefinition
    {
        /// <summary>
        ///     Device type. Only "OtherPhone" and "WebRTC" device types are supported at the moment
        ///     Required
        ///     Enum: OtherPhone, WebRTC
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Only "address" is supported at the moment
        ///     Required
        /// </summary>
        public DeviceDefinitionEmergency emergency { get; set; }

        /// <summary>
        ///     To be used to assign a number by id
        ///     Required
        /// </summary>
        public DeviceDefinitionPhoneInfo phoneInfo { get; set; }
    }
}