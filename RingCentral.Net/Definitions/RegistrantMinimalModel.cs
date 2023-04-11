namespace RingCentral
{
    public class RegistrantMinimalModel
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
    }
}