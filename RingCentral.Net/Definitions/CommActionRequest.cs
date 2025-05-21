namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommActionRequest
    {
        /// <summary>
        ///     Required
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }
    }
}