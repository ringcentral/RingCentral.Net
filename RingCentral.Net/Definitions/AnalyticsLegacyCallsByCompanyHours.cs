namespace RingCentral
{
    public class AnalyticsLegacyCallsByCompanyHours
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? businessHours { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? afterHours { get; set; }
    }
}