namespace RingCentral
{
    public class CommTerminatingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }
    }
}