namespace RingCentral
{
    public class RegSessionModel
    {
        /// <summary>
        ///     ID of the session
        ///     Required
        ///     Example: 123456789
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Status of the registration
        ///     Required
        ///     Example: Open
        ///     Enum: Open, Closed
        /// </summary>
        public string registrationStatus { get; set; }

        /// <summary>
        ///     The URI of the registration landing page
        ///     Format: uri
        ///     Example: https://abcde12345.webinar.ringcentral.com/register
        /// </summary>
        public string registrationPageUri { get; set; }

        /// <summary>
        ///     The URI of the branding descriptor
        ///     Format: uri
        ///     Example: https://abcde12345.webinar.ringcentral.com/branding
        /// </summary>
        public string brandingDescriptorUri { get; set; }

        /// <summary>
        ///     The current number of registrants
        ///     Required
        ///     Format: int32
        ///     Example: 10
        /// </summary>
        public long? registrantCount { get; set; }

        /// <summary>
        ///     The current number of post webinar registrants
        ///     Format: int32
        ///     Example: 10
        /// </summary>
        public long? postWebinarRegistrantCount { get; set; }

        /// <summary>
        ///     Indicates that there are non-test registrants
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? hasRealRegistrants { get; set; }

        /// <summary>
        ///     Sequence number for iCalendar email attachments
        ///     Format: int32
        /// </summary>
        public long? icalendarSequence { get; set; }

        /// <summary>
        /// </summary>
        public RegSessionModelSettings settings { get; set; }
    }
}