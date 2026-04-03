namespace RingCentral
{
    public class EmergencyAddress
    {
        /// <summary>
        ///     If set to `true` then specifying emergency address is required
        /// </summary>
        public bool? required { get; set; }

        /// <summary>
        ///     If set to `true` then only local emergency address can be specified
        /// </summary>
        public bool? localOnly { get; set; }

        /// <summary>
        ///     This status is associated with a phone line provision state
        ///     Enum: Valid, Provisioning, Invalid
        /// </summary>
        public string lineProvisioningStatus { get; set; }
    }
}