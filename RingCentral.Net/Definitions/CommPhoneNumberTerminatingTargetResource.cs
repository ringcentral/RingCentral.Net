namespace RingCentral
{
    public class CommPhoneNumberTerminatingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Example: PhoneNumberTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: Ringing, Terminating
        /// </summary>
        public string dispatchingType { get; set; }
    }
}