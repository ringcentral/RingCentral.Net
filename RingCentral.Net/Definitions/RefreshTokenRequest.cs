namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Refresh Token" flow
    ///     with the `refresh_token` grant type
    /// </summary>
    public class RefreshTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Enum: refresh_token
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `refresh_token` grant type only. Previously issued refresh token.
        ///     Required
        /// </summary>
        public string refresh_token { get; set; }
    }
}