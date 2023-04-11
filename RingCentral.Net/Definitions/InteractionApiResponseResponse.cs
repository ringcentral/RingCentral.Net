namespace RingCentral
{
    public class InteractionApiResponseResponse
    {
        /// <summary>
        /// </summary>
        public UtteranceInsightsObject[] utteranceInsights { get; set; }

        /// <summary>
        /// </summary>
        public SpeakerInsightsObject speakerInsights { get; set; }

        /// <summary>
        /// </summary>
        public ConversationalInsightsUnit[] conversationalInsights { get; set; }
    }
}