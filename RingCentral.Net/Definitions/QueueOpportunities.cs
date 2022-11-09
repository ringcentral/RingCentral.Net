namespace RingCentral
{
    /// <summary>
    ///     Queue opportunities data for the specified grouping
    /// </summary>
    public class QueueOpportunities
    {
        /// <summary>
        ///     Unit of the result value
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Value for queue opportunities
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? values { get; set; }
    }
}