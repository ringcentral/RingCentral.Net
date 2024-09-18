namespace RingCentral
{
    public class RegSessionModelSettings
    {
        /// <summary>
        ///     The maximum number of registrants which forces closing the registration (0 means "off").
        ///     Format: int32
        /// </summary>
        public long? autoCloseLimit { get; set; }

        /// <summary>
        ///     Indicates that emails to registrants should be suppressed (should be supported by external party)
        /// </summary>
        public bool? suppressEmails { get; set; }

        /// <summary>
        ///     Indicates that registration digest should be sent to host.
        ///     Default: true
        /// </summary>
        public bool? registrationDigestEnabled { get; set; }

        /// <summary>
        ///     Indicates that registrants are allowed to join from multiple devices.
        /// </summary>
        public bool? preventMultipleDeviceJoins { get; set; }

        /// <summary>
        ///     Indicates that work email address is required for registration.
        /// </summary>
        public bool? workEmailRequired { get; set; }

        /// <summary>
        ///     Indicates that recording will be shown after the webinar and in emails.
        /// </summary>
        public bool? viewRecording { get; set; }

        /// <summary>
        ///     Duration of on-demand webinar. The default value can only be used if the session is on demand.
        ///     Default: SixMonths
        ///     Enum: OneMonth, TwoMonths, ThreeMonths, SixMonths, OneYear
        /// </summary>
        public string onDemandDuration { get; set; }

        /// <summary>
        ///     Indicates that recording exists for the session.
        /// </summary>
        public bool? recordingExist { get; set; }

        /// <summary>
        ///     Indicates that post webinar registration will be opened automatically when webinar ends.
        /// </summary>
        public bool? autoOpenPostWebinarRegistration { get; set; }

        /// <summary>
        ///     The time after which the post webinar will be closed automatically.
        ///     Format: date-time
        /// </summary>
        public string postWebinarRegistrationClosingTime { get; set; }
    }
}