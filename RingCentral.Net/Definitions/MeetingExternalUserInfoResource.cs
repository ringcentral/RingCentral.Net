namespace RingCentral
{
    public class MeetingExternalUserInfoResource
    {
        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// </summary>
        public long? userType { get; set; }

        /// <summary>
        /// </summary>
        public string userToken { get; set; }

        /// <summary>
        /// </summary>
        public string hostKey { get; set; }

        /// <summary>
        /// </summary>
        public string personalMeetingId { get; set; }

        /// <summary>
        /// Link to the user's personal meeting room, used as an alias for personal meeting URL (with personal meeting ID)
        /// </summary>
        public string personalLink { get; set; }

        /// <summary>
        /// Enables using personal meeting ID for instant meetings
        /// </summary>
        public bool? usePmiForInstantMeetings { get; set; }
    }
}