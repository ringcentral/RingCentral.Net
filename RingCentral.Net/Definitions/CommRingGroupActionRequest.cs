namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommRingGroupActionRequest
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
        ///     Required
        /// </summary>
        public CommRingGroupActionRequestTargets[] targets { get; set; }

        /// <summary>
        ///     Custom start time. Applicable for 'Custom' dispatching type
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? customStartOffset { get; set; }

        /// <summary>
        ///     Duration of calling
        ///     Required
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? duration { get; set; }
    }
}