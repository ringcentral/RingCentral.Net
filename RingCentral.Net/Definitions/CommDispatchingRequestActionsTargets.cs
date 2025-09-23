namespace RingCentral
{
    public class CommDispatchingRequestActionsTargets
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
        public CommDeviceRequest device { get; set; }

        /// <summary>
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationRequest integration { get; set; }

        /// <summary>
        ///     Phone number name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CommTerminatingPromptResource prompt { get; set; }

        /// <summary>
        ///     Enum: Ringing, Terminating
        /// </summary>
        public string dispatchingType { get; set; }
    }
}