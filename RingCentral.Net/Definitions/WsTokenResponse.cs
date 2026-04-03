namespace RingCentral
{
    public class WsTokenResponse
    {
        /// <summary>
        ///     The websocket access token to be used when connecting to the Websocket Gateway.
        ///     Required
        /// </summary>
        public string ws_access_token { get; set; }

        /// <summary>
        ///     The URI of RingCentral Websocket Gateway.
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Websocket access token TTL (time-to-live) in seconds
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? expires_in { get; set; }
    }
}