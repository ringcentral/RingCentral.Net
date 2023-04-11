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
    }
}