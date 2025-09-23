namespace RingCentral
{
    /// <summary>
    ///     All Mobile Ring target
    /// </summary>
    public class CommAllMobileTargetResource
    {
        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Example: AllMobileRingTarget
        ///     Enum: AllMobileRingTarget
        /// </summary>
        public string type { get; set; }
    }
}