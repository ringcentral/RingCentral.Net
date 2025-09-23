namespace RingCentral
{
    /// <summary>
    ///     All Mobile Ring target
    /// </summary>
    public class CommAllMobileRingAlwaysRingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type. Applicable for all desktop and mobile applications.
        ///     Ensures applications ring all the time during a call
        ///     Required
        ///     Example: AllMobileRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}