namespace RingCentral
{
    public class CommVoiceMailTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Example: VoiceMailTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommTerminatingPromptResource prompt { get; set; }
    }
}