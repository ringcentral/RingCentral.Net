namespace RingCentral
{
    public class PerformanceCallsCounter
    {
        /// <summary>
        ///     Type of aggregation. If set to 'Min', 'Max' or 'Average' then `aggregationInterval` is supported. If set to 'Sum'
        ///     or 'Percent' then `aggregationInterval` is not supported
        ///     Required
        ///     Enum: Sum, Average, Max, Min, Percent
        /// </summary>
        public string aggregationType { get; set; }

        /// <summary>
        ///     Interval of aggregation
        ///     Enum: Hour, Day, Week, Month
        /// </summary>
        public string aggregationInterval { get; set; }
    }
}