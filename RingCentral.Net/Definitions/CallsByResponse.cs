namespace RingCentral
{
    public class CallsByResponse
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? answered { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? notAnswered { get; set; }
    }
}