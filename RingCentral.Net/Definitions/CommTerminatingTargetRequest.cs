namespace RingCentral
{
    public class CommTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }
    }
}