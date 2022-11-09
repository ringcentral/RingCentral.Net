namespace RingCentral
{
    /// <summary>
    ///     An action that will be invoked when the card is tapped or selected. `Action.ShowCard` is not supported
    /// </summary>
    public class AdaptiveCardSelectAction
    {
        /// <summary>
        ///     Required
        ///     Enum: Action.Submit, Action.OpenUrl, Action.ToggleVisibility
        /// </summary>
        public string type { get; set; }
    }
}