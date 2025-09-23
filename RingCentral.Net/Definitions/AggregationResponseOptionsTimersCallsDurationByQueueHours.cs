namespace RingCentral
{
    public class AggregationResponseOptionsTimersCallsDurationByQueueHours
    {
        /// <summary>
        ///     Counter aggregation type. Can be `Sum`, `Average`, `Min`, `Max` or `Percent`
        ///     Enum: Sum, Average, Max, Min, Percent
        /// </summary>
        public string aggregationType { get; set; }

        /// <summary>
        ///     Time interval which will be used for aggregation. Can be `Hour`, `Day`, `Week` or `Month`
        ///     Enum: Hour, Day, Week, Month
        /// </summary>
        public string aggregationInterval { get; set; }
    }
}