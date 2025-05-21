namespace RingCentral
{
    /// <summary>
    ///     All Desktop Ring target
    /// </summary>
    public class CommAllDesktopTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Example: AllDesktopRingTarget
        ///     Enum: AllDesktopRingTarget
        /// </summary>
        public string type { get; set; }
    }
}