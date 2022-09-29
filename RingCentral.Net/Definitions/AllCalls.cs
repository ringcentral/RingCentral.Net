namespace RingCentral
{
    /// <summary>
    ///     Data for all calls
    /// </summary>
    public class AllCalls
    {
        /// <summary>
        ///     Unit of the result value
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Value for all calls
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? values { get; set; }
    }
}