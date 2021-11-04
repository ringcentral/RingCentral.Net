namespace RingCentral
{
    public class CallsBySegments
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? ringing { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? liveTalk { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? holds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? parks { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? transfers { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? ivrPrompts { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? voiceMailing { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? vmGreetings { get; set; }
    }
}