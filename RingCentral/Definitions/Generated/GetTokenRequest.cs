namespace RingCentral
{
    public class GetTokenRequest
    {
        // Phone number linked to an account or extension in E.164 format with or without leading '+' sign
        public string username;

        // User's password
        public string password;

        // Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator
        public string extension;

        // Grant type
        public string grant_type;

        // Access token lifetime in seconds
        public long? access_token_ttl;

        // Refresh token lifetime in seconds
        public long? refresh_token_ttl;

        // List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase
        public string scope;

        // Previously issued refresh token. This is the only formData field used for the Refresh Token Flow.
        public string refresh_token;

        // The unique identifier of a client application. If not specified, the previously specified or auto generated value is used by default
        public string endpoint_id;

        // The authorization code that the client previously received from the authorization server
        public string code;
    }
}