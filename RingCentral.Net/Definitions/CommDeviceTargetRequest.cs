namespace RingCentral
{
    public class CommDeviceTargetRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommDeviceRequest device { get; set; }

        /// <summary>
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