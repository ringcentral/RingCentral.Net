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
        ///     Example: YoutTube
        /// </summary>
        public string serviceProvider { get; set; }

        /// <summary>
        ///     Last known state of the livestream as notified by Webinar Livestreaming Controller Service (WLCS).
        ///     Value may not be consistent with latest state, especially for livestream associated with OAuth2.0 based service
        ///     providers.
        ///     Thus, state must be obtained directly from WLCS
        ///     Required
        ///     Example: Initialized
        ///     Enum: Initialized, Authorized, Configured, PublishSetup, Publishing, Paused, Error, Break, Deleted, Completed
        /// </summary>
        public string livestreamStatus { get; set; }

        /// <summary>
        ///     Last known state of the livestream as notified by Webinar Livestreaming Controller Service (WLCS).
        ///     Value may not be consistent with latest state, especially for livestream associated with OAuth2.0 based service
        ///     providers.
        ///     Thus, state must be obtained directly from WLCS
        ///     Example: Initialized
        ///     Enum: Initialized, Authorized, Configured, PublishSetup, Publishing, Paused, Error, Break, Deleted, Completed
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