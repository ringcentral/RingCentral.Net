namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by company hours (BusinessHours, AfterHours)
    /// </summary>
    public class CallsByCompanyHours
    {
        /// <summary>
        ///     Unit of the result value
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByCompanyHoursBreakdown values { get; set; }
    }
}