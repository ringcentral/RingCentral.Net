namespace RingCentral
{
    public class RecordingModel
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Object creation time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Object last modification time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

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
        ///     Indicates if Host or Admin has shared a recording.
        ///     Can be set to true only then recording status is 'Available'.
        ///     Example: true
        /// </summary>
        public bool? shared { get; set; }

        /// <summary>
        ///     Time after which recording shared link cannot be accessed by recipients.
        ///     Format: date-time
        ///     Example: Sun Oct 01 2023 03:05:00 GMT-0700 (Pacific Daylight Time)
        /// </summary>
        public string sharedUriExpirationTime { get; set; }
    }
}