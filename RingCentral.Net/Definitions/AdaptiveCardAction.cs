namespace RingCentral
{
    public class AdaptiveCardAction
    {
        /// <summary>
        ///     Enum: Action.ShowCard, Action.Submit, Action.OpenUrl, Action.ToggleVisibility
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// </summary>
        public ActionAdaptiveCardInfo card { get; set; }

        /// <summary>
        /// </summary>
        public string url { get; set; }
    }
}