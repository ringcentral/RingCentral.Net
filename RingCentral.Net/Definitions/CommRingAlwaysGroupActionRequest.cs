namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommRingAlwaysGroupActionRequest
    {
        /// <summary>
        ///     Required
        ///     Example: RingAlwaysGroupAction
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
        public CommRingAlwaysGroupActionRequestTargets[] targets { get; set; }
    }
}