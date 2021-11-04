namespace RingCentral
{
    public class CallsByOrigin
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? @internal { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? external { get; set; }
    }
}