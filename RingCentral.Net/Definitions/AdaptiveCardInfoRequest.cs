namespace RingCentral
{
    public class AdaptiveCardInfoRequest
    {
        /// <summary>
        ///     Enum: Container
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardInfoRequestItem[] items { get; set; }
    }
}