namespace RingCentral
{
    public class CommDispatchingRequestActionsTargets
    {
        /// <summary>
        ///     Terminating target type
        ///     Example: CloudConnectorTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget, VoiceMailTerminatingTarget, CloudConnectorTerminatingTarget
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
        public CommCloudDestination destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationRequest integration { get; set; }

        /// <summary>
        ///     The customised target name
        ///     Example: Cloud Connector Contact
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