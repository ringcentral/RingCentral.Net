using Newtonsoft.Json;

namespace RingCentral
{
    public class TokenInfo : Serializable
    {
        // Access token to pass to subsequent API requests
        public string access_token;
        // Issued access token TTL (time to live), in seconds
        public long? expires_in;
        // Refresh token to get a new access token, when the issued one expires
        public string refresh_token;
        // Issued refresh token TTL (time to live), in seconds
        public long? refresh_token_expires_in;
        // List of permissions allowed with this access token, white-space separated
        public string scope;
        // Type of token. The only possible value supported is Bearer. This value should be used when specifying access token in Authorization header of subsequent API requests
        public string token_type;
        // Extension identifier
        public string owner_id;
        // Application instance identifier
        public string endpoint_id;
    }
}