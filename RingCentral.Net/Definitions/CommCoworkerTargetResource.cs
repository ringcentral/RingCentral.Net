namespace RingCentral
{
    /// <summary>
    ///     Ring target
    /// </summary>
    public class CommCoworkerTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Type of a ring target
        ///     Example: CoworkerRingTarget
        ///     Enum: CoworkerRingTarget
        /// </summary>
        public string type { get; set; }
    }
}