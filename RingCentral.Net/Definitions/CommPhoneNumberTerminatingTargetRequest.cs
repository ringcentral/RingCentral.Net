namespace RingCentral
{
    public class CommPhoneNumberTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Example: PhoneNumberTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Phone number name
        /// </summary>
        public string name { get; set; }

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