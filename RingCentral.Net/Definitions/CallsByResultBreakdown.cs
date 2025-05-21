namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by call result
    /// </summary>
    public class CallsByResultBreakdown
    {
        /// <summary>
        ///     Value for Completed result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? completed { get; set; }

        /// <summary>
        ///     Value for Abandoned result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? abandoned { get; set; }

        /// <summary>
        ///     Value for Voicemail result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? voicemail { get; set; }

        /// <summary>
        ///     Value for Missed result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? missed { get; set; }

        /// <summary>
        ///     Value for Accepted result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? accepted { get; set; }

        /// <summary>
        ///     Value for Unknown result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? unknown { get; set; }

        /// <summary>
        ///     Value for Transferred result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? transferred { get; set; }

        /// <summary>
        ///     Value for PickedUp result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? pickedUp { get; set; }

        /// <summary>
        ///     Value for AnsweredElsewhere result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? answeredElsewhere { get; set; }

        /// <summary>
        ///     Value for Forwarded result
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? forwarded { get; set; }
    }
}