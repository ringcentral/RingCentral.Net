namespace RingCentral
  {
    /// <summary>
/// Query parameters for operation getSessionInsights
/// </summary>
      public class GetSessionInsightsParameters
      {
          /// <summary>
        ///     AI Insight Types
        ///     Enum: NextSteps, Transcript, Summary, Highlights, BulletedSummary, AIScore, CallNotes, Sentiment
        /// </summary>
        public string[] insightTypes { get; set; }
      }
  }