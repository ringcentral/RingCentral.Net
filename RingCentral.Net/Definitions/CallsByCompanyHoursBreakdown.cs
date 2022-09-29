namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by company hours
    /// </summary>
    public class CallsByCompanyHoursBreakdown
    {
        /// <summary>
        ///     Value for BusinessHours company hours
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? businessHours { get; set; }

        /// <summary>
        ///     Value for AfterHours company hours
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? afterHours { get; set; }
    }
}