namespace RingCentral
{
    public class MeetingServiceInfoResource
    {
        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string supportUri { get; set; }

        /// <summary>
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