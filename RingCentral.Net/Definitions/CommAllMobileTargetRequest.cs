namespace RingCentral
{
    /// <summary>
    ///     All Mobile Ring target
    /// </summary>
    public class CommAllMobileTargetRequest
    {
        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Example: AllMobileRingTarget
        ///     Enum: AllMobileRingTarget
        /// </summary>
        public string type { get; set; }
    }
}