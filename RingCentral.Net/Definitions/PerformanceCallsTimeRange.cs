namespace RingCentral
{
    /// <summary>
    ///     Date-time range for the calls aggregated. A call is considered to be in the time range if it started within the
    ///     time frame specified. Both borders are inclusive.
    /// </summary>
    public class PerformanceCallsTimeRange
    {
        /// <summary>
        ///     The start date-time for resulting records in [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format including
        ///     timezone, for example 2016-03-15T18:07:52.534Z.
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string timeFrom { get; set; }

        /// <summary>
        ///     The end date-time for resulting records in [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format including
        ///     timezone, for example 2016-03-15T18:07:52.534Z.
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string timeTo { get; set; }
    }
}