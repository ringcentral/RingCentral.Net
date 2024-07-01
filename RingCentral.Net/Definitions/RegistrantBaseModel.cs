namespace RingCentral
{
    public class RegistrantBaseModel
    {
        /// <summary>
        ///     First (given) name
        ///     Required
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last (family) name
        ///     Required
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     User's contact email
        ///     Required
        ///     Format: email
        ///     Example: john.doe@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     The personalized URI for this registrant to join the Webinar
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/a/join/iuyef77fsj473wn10ashjfk34
        /// </summary>
        public string joinUri { get; set; }

        /// <summary>
        ///     The personalized URI for this registrant to cancel the registration
        ///     Format: uri
        ///     Example: https://abcde12345.webinar.ringcentral.com/register?jlt=iuyef77fsj473wn10ashjfk34&action=cancel
        /// </summary>
        public string cancellationUri { get; set; }

        /// <summary>
        ///     Indicates if the registrant was registered to on-demand webinar
        /// </summary>
        public bool? registeredPostWebinar { get; set; }

        /// <summary>
        ///     Visitor ID passed from registration page
        /// </summary>
        public string visitorId { get; set; }

        /// <summary>
        ///     ID of a registrant passed from external system
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        ///     Registration time (can be earlier than "creationTime" due to indirect persistence)
        ///     Format: date-time
        /// </summary>
        public string registrationTime { get; set; }

        /// <summary>
        ///     IP address of the registrant's user agent
        ///     Format: ipv4
        /// </summary>
        public string ipAddress { get; set; }

        /// <summary>
        ///     Registration channel source (coming from registration URI)
        /// </summary>
        public string source { get; set; }

        /// <summary>
        ///     ID of session participant (from Runtime Service - if this registrant attended the webinar)
        /// </summary>
        public string participantId { get; set; }
    }
}