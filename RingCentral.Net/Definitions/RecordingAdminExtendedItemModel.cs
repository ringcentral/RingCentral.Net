namespace RingCentral
{
    public class RecordingAdminExtendedItemModel
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
        ///     Example: 2023-10-01T10:05:00.000Z
        /// </summary>
        public string sharedUriExpirationTime { get; set; }

        /// <summary>
        ///     Shared URI of the recording. If a password was required to join a webinar, the URI should contain the password
        ///     encoded
        ///     Required
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/a/recording/de7yd8ew7yfsdfjh899843rgj?pw=a1b2c3d4
        /// </summary>
        public string recordingSharedUri { get; set; }

        /// <summary>
        /// </summary>
        public SessionRefAdminModel session { get; set; }
    }
}