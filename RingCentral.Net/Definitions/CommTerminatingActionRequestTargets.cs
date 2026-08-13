namespace RingCentral
{
    public class CommTerminatingActionRequestTargets
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
        public CommTerminatingPromptResource prompt { get; set; }

        /// <summary>
        ///     Enum: Ringing, Terminating
        /// </summary>
        public string dispatchingType { get; set; }

        /// <summary>
        ///     The customised target name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CommCloudDestination destination { get; set; }
    }
}