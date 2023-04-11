namespace RingCentral
{
    public class SummaryInput
    {
        /// <summary>
        ///     Type of summary to be computed
        ///     Required
        ///     Example: AbstractiveShort
        ///     Enum: Extractive, AbstractiveShort, AbstractiveLong, AbstractiveAll, All
        /// </summary>
        public string summaryType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SummaryUnit[] utterances { get; set; }
    }
}