namespace RingCentral
{
    public class CommRingAlwaysRingTargetResource
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type. Applicable for all desktop and mobile applications.
        ///     Ensures applications ring all the time during a call
        ///     Required
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget
        /// </summary>
        public string type { get; set; }
    }
}