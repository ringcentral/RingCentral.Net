namespace RingCentral
{
    public class SpeakerInsightsUnit
    {
        /// <summary>
        ///     Required
        ///     Example: TalkToListenRatio
        ///     Enum: Energy, Pace, TalkToListenRatio
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SpeakerInsightsValuesItems[] values { get; set; }
    }
}