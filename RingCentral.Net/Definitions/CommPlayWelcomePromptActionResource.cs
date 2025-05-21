namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommPlayWelcomePromptActionResource
    {
        /// <summary>
        ///     Required
        ///     Example: PlayWelcomePromptAction
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommGreetingResource greeting { get; set; }

        /// <summary>
        ///     Specifies if an action is enabled
        ///     Required
        /// </summary>
        public bool? enabled { get; set; }
    }
}