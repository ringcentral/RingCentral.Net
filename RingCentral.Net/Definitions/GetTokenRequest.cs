namespace RingCentral
{
    public class GetTokenRequest
    {
        /// <summary>
        /// <b>Phone number linked to account or extension in account in E.164 format with or without leading "+" sign</b>
        /// </summary>
        public string username;

        /// <summary>
        /// <b>User's password</b>
        /// </summary>
        public string password;

        /// <summary>
        /// Optional. Extension short number. If company number is specified as a username, and "extension" is not specified, the server will attempt to authenticate client as main company administrator
        /// </summary>
        public string extension;

        /// <summary>
        /// <b>Must hold "password" value for Resource Owner Credentials flow</b>
        /// Default: password
        /// </summary>
        public string grant_type;

        /// <summary>
        /// Optional. Access token lifetime in seconds; the possible values are from 600 sec (10 min) to 3600 sec (1 hour). The default value is 3600 sec. If the value specified exceeds the default one, the default value is set. If the value specified is less than 600 seconds, the minimum value (600 sec) is set
        /// </summary>
        public long? access_token_ttl;

        /// <summary>
        /// Optional. Refresh token lifetime in seconds; default is 604800 sec (1 week). If the value specified exceeds the default one, the default value is set
        /// </summary>
        public long? refresh_token_ttl;

        /// <summary>
        /// List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase
        /// </summary>
        public string scope;

        /// <summary>
        /// Previously issued refresh token. This is the only formData field used for the Refresh Token Flow. It is not used for the Resource Owner Password Credentials Flow
        /// </summary>
        public string refresh_token;

        /// <summary>
        /// </summary>
        public string brand_id;

        /// <summary>
        /// </summary>
        public string endpoint_id;

        /// <summary>
        /// </summary>
        public string pin;

        /// <summary>
        /// </summary>
        public string client_id;

        /// <summary>
        /// </summary>
        public string redirect_uri;

        /// <summary>
        /// </summary>
        public string code;

        /// <summary>
        /// </summary>
        public string account_id;

        /// <summary>
        /// </summary>
        public string partner_account_id;

        /// <summary>
        /// </summary>
        public string client_assertion_type;

        /// <summary>
        /// </summary>
        public string client_assertion;

        /// <summary>
        /// </summary>
        public string assertion;
    }
}