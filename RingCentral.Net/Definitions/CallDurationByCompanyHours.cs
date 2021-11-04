namespace RingCentral
{
    public class CallDurationByCompanyHours
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? businessHoursSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? afterHoursSeconds { get; set; }
    }
}