namespace RingCentral
{
    public class SummaryOutputUnit
    {
        /// <summary>
        ///     Example: AbstractiveShort
        ///     Enum: Extractive, AbstractiveLong, AbstractiveShort, All
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Summary output units sorted by their occurrence in the conversation
        /// </summary>
        public SummaryTimingsUnit[] values { get; set; }
    }
}