namespace RingCentral
{
    public class CommFmcPhoneNumberTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: FmcPhoneNumberRingTarget
        ///     Enum: FmcPhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}