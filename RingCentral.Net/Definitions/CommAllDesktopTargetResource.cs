namespace RingCentral
{
    /// <summary>
    ///     All Desktop Ring target
    /// </summary>
    public class CommAllDesktopTargetResource
    {
        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Example: AllDesktopRingTarget
        ///     Enum: AllDesktopRingTarget
        /// </summary>
        public string type { get; set; }
    }
}