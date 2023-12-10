namespace RingCentral
{
    public class EnrollmentStatus
    {
        /// <summary>
        ///     Quality of the enrollment.
        ///     Example: Average
        ///     Enum: Poor, Average, Good, High
        /// </summary>
        public string enrollmentQuality { get; set; }

        /// <summary>
        ///     Status of the enrollment.
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? enrollmentComplete { get; set; }

        /// <summary>
        ///     Required
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     Total speech duration of the enrollment in seconds.
        ///     Format: float
        ///     Example: 20.1
        /// </summary>
        public decimal? totalEnrollDuration { get; set; }

        /// <summary>
        ///     Total duration of the enrollment in seconds.
        ///     Required
        ///     Format: float
        ///     Example: 30.5
        /// </summary>
        public decimal? totalSpeechDuration { get; set; }
    }
}