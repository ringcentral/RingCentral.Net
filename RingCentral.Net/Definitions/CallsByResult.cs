namespace RingCentral
{
    public class CallsByResult
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? completed { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? abandoned { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? voiceMail { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? connected { get; set; }
    }
}