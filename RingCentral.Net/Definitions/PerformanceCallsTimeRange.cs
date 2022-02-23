namespace RingCentral
{
    public class PerformanceCallsTimeRange
    {
        /// <summary>
        ///     The start date-time for resulting records in RFC 3339 format including timezone, for example
        ///     2016-03-15T18:07:52.534Z
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string timeFrom { get; set; }

        /// <summary>
        ///     The end date-time for resulting records in RFC 3339 format including timezone, for example 2016-03-15T18:07:52.534Z
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string timeTo { get; set; }
    }
}