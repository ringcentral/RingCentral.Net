using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MeetingServiceInfoResource : Serializable
    {
        public string uri;
        public string supportUri;
        public string intlDialInNumbersUri;
        public MeetingExternalUserInfoResource externalUserInfo;
        public DialInNumberResource[] dialInNumbers;
    }
}