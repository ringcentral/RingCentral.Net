namespace RingCentral
{
    public class InteractionObject
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