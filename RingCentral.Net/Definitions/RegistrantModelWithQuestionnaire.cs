namespace RingCentral
{
    public class RegistrantModelWithQuestionnaire
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

        /// <summary>
        ///     Answers on custom registration questions
        /// </summary>
        public RegAnswerModel[] questionnaire { get; set; }
    }
}