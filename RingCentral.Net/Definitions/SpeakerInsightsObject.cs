namespace RingCentral
{
    public class SpeakerInsightsObject
    {
        /// <summary>
        ///     Format: int32
        ///     Example: 3
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        /// </summary>
        public SpeakerInsightsUnit[] insights { get; set; }
    }
}