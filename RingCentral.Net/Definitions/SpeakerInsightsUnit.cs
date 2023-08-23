namespace RingCentral
{
    public class SpeakerInsightsUnit
    {
        /// <summary>
        ///     Required
        ///     Example: TalkToListenRatio
        ///     Enum: Energy, Pace, TalkToListenRatio, Patience, LongestMonologue, FillerWordRate, TalkingSpeed, TalkTime,
        ///     QuestionsAsked, Tone, Interruptions
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SpeakerInsightsValuesItems[] values { get; set; }
    }
}