namespace RingCentral
{
    public class OauthTokenRequest : Serializable
    {
        public string grant_type;
        public string username;
        public string extension;
        public string password;
        public string scope;
        public string refresh_token;
        public string endpoint_id;
    }
}
