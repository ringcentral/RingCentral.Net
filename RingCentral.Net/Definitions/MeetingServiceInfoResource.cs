namespace RingCentral
{
    public class MeetingServiceInfoResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string supportUri { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string intlDialInNumbersUri { get; set; }

        /// <summary>
        /// </summary>
        public MeetingExternalUserInfoResource externalUserInfo { get; set; }

        /// <summary>
        /// </summary>
        public DialInNumberResource[] dialInNumbers { get; set; }
    }
}