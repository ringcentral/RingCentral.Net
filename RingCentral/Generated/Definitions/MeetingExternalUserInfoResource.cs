using Newtonsoft.Json;

namespace RingCentral
{
    public class MeetingExternalUserInfoResource : Serializable
    {
        public string uri;
        public string userId;
        public string accountId;
        public int? userType;
        public string userToken;
    }
}