namespace RingCentral
{
    /// <summary>
    ///     Returns the list of recurring licenses on the account
    /// </summary>
    public class LicensesStatisticsResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public LicensesStatisticsResponseItem[] licenses { get; set; }
    }
}