namespace RingCentral
{
    public class RecordingBaseModel
    {
        /// <summary>
        ///     Recording status
        ///     Required
        ///     Example: Available
        ///     Enum: Processing, Available, Failed, Purged
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ApiError failureReason { get; set; }

        /// <summary>
        ///     Recording duration in seconds
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 3600
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        /// </summary>
        public RecordingSharedStatusModel shared { get; set; }

        /// <summary>
        ///     Time after which recording shared link cannot be accessed by recipients.
        ///     Format: date-time
        ///     Example: 2023-10-01T10:05:00.000Z
        /// </summary>
        public string sharedUriExpirationTime { get; set; }
    }
}