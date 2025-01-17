namespace RingCentral
{
    public class AIInsights
    {
        /// <summary>
        /// </summary>
        public TranscriptInsightUnit[] Transcript { get; set; }

        /// <summary>
        /// </summary>
        public SummaryInsightUnit[] Summary { get; set; }

        /// <summary>
        /// </summary>
        public HighlightsInsightUnit[] Highlights { get; set; }

        /// <summary>
        /// </summary>
        public NextStepsInsightUnit[] NextSteps { get; set; }

        /// <summary>
        /// </summary>
        public BulletedSummaryInsightUnit[] BulletedSummary { get; set; }

        /// <summary>
        /// </summary>
        public AIScoreInsightUnit[] AIScore { get; set; }
    }
}