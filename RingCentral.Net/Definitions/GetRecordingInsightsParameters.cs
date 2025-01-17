namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation getRecordingInsights
    /// </summary>
    public class GetRecordingInsightsParameters
    {
        /// <summary>
        ///     AI Insight Types
        ///     Enum: NextSteps, Transcript, Summary, Highlights, BulletedSummary, AIScore
        /// </summary>
        public string[] insightTypes { get; set; }
    }
}