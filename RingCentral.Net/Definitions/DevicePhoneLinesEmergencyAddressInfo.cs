namespace RingCentral
{
    public class DevicePhoneLinesEmergencyAddressInfo
    {
        /// <summary>
        /// 'True' if specifying of emergency address is required
        /// </summary>
        public bool? required { get; set; }

        /// <summary>
        /// 'True' if only local emergency address can be specified
        /// </summary>
        public bool? localOnly { get; set; }
    }
}