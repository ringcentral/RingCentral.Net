namespace RingCentral
{
    public class MeetingExternalUserInfoResource
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string userId;

        /// <summary>
        /// </summary>
        public string accountId;

        /// <summary>
        /// </summary>
        public long? userType;

        /// <summary>
        /// </summary>
        public string userToken;

        /// <summary>
        /// </summary>
        public string hostKey;

        /// <summary>
        /// </summary>
        public string personalMeetingId;

        /// <summary>
        /// Link to the user's personal meeting room, used as an alias for personal meeting URL (with personal meeting ID)
        /// </summary>
        public string personalLink;

        /// <summary>
        /// Enables using personal meeting ID for instant meetings
        /// </summary>
        public bool? usePmiForInstantMeetings;
    }
}