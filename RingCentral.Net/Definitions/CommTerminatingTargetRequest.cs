namespace RingCentral
{
    public class CommTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }
    }
}