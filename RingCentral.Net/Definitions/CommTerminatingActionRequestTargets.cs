namespace RingCentral
{
    public class CommTerminatingActionRequestTargets
    {
        /// <summary>
        ///     Terminating target type
        ///     Example: ExtensionTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        /// </summary>
        public CommTerminatingPromptResource prompt { get; set; }

        /// <summary>
        ///     Enum: Ringing, Terminating
        /// </summary>
        public string dispatchingType { get; set; }

        /// <summary>
        ///     Phone number name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
    }
}