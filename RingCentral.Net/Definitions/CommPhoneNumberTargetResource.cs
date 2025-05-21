namespace RingCentral
{
    public class CommPhoneNumberTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: PhoneNumberRingTarget
        ///     Enum: PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}