namespace RingCentral
{
    public class CommDeviceTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommDeviceResource device { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: DeviceRingTarget
        ///     Enum: DeviceRingTarget
        /// </summary>
        public string type { get; set; }
    }
}