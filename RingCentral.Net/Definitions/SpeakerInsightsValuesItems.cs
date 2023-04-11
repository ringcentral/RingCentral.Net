namespace RingCentral
{
    public class SpeakerInsightsValuesItems
    {
        /// <summary>
        ///     Required
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     The value corresponding to the insight for the speaker
        ///     Required
        ///     Example: 20:80
        /// </summary>
        public string value { get; set; }
    }
}