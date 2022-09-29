namespace RingCentral
{
    public class DevicePhoneLinesEmergencyAddressInfo
    {
        /// <summary>
        ///     Indicates that emergency address is required
        /// </summary>
        public bool? required { get; set; }

        /// <summary>
        ///     Indicates that only local emergency address can be specified
        /// </summary>
        public bool? localOnly { get; set; }
    }
}