namespace RingCentral
{
    public class CallsDurationByOrigin
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? internalCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? externalCallsSeconds { get; set; }
    }
}