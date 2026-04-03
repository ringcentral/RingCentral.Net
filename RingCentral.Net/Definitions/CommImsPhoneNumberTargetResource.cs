namespace RingCentral
{
    public class CommImsPhoneNumberTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: ImsPhoneNumberRingTarget
        ///     Enum: ImsPhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}