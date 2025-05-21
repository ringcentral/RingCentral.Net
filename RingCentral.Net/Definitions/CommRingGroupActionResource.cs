namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommRingGroupActionResource
    {
        /// <summary>
        ///     Action type
        ///     Required
        ///     Example: RingGroupAction
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Specifies if an action is enabled
        ///     Required
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Target information
        ///     Required
        /// </summary>
        public CommRingGroupActionResourceTargets[] targets { get; set; }

        /// <summary>
        ///     Custom start time in seconds. Applicable for 'Custom' dispatching type
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? customStartOffset { get; set; }

        /// <summary>
        ///     Duration of calling in seconds
        ///     Required
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? duration { get; set; }
    }
}