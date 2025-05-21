namespace RingCentral
{
    public class CommImsVoiceMailTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Example: ImsVoiceMailTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }
    }
}