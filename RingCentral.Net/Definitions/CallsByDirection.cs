namespace RingCentral
{
    public class CallsByDirection
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? inbound { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outbound { get; set; }
    }
}