namespace RingCentral
{
    public class MeetingExternalUserInfoResource : Serializable
    {
        public string uri;
        public string userId;
        public string accountId;
        public long? userType;
        public string userToken;
    }
}