namespace RingCentral
{
    public class CommCloudConnectorTerminatingTargetRequest
    {
        /// <summary>
        ///     Terminating target type
        ///     Required
        ///     Example: CloudConnectorTerminatingTarget
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget, VoiceMailTerminatingTarget, CloudConnectorTerminatingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: Ringing, Terminating
        /// </summary>
        public string dispatchingType { get; set; }

        /// <summary>
        ///     The customised target name
        ///     Required
        /// </summary>
        public string name { get; set; }
    }
}