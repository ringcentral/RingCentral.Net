namespace RingCentral
{
    public class BulletedSummaryInsightUnit
    {
        /// <summary>
        ///     Value of the summary
        ///     Required
        ///     Example: conversational insights text
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Section of the summary
        ///     Example: section name
        /// </summary>
        public string section { get; set; }
    }
}