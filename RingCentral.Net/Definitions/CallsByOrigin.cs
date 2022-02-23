namespace RingCentral
{
    public class CallsByOrigin
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? @internal { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? external { get; set; }
    }
}