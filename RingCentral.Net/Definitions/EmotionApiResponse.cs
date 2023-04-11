namespace RingCentral
{
    public class EmotionApiResponse
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public EmotionSegment[] response { get; set; }
    }
}