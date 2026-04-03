namespace RingCentral
{
    public class SessionLivestreamMinimalModel
    {
        /// <summary>
        ///     Identifier of the livestream
        ///     Required
        ///     Example: 40740e06-4eec-4458-a86e-8578e192274q
        /// </summary>
        public string livestreamId { get; set; }

        /// <summary>
        ///     Name of the livestreaming service provider
        ///     Required
        ///     Example: YouTube
        /// </summary>
        public string serviceProvider { get; set; }

        /// <summary>
        ///     Livestream status
        ///     Required
        ///     Example: Configured
        ///     Enum: Initialized, Authorized, Configured, PublishSetup, Publishing, Error, Paused, Break, Deleted, Completed
        /// </summary>
        public string livestreamStatus { get; set; }

        /// <summary>
        ///     Livestream status
        ///     Example: Configured
        ///     Enum: Initialized, Authorized, Configured, PublishSetup, Publishing, Error, Paused, Break, Deleted, Completed
        /// </summary>
        public string previousLivestreamStatus { get; set; }

        /// <summary>
        ///     Time at which the session started to publish media to livestream service provider.
        ///     Format: date-time
        /// </summary>
        public string livestreamStartTime { get; set; }

        /// <summary>
        /// </summary>
        public ApiError error { get; set; }
    }
}