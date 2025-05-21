namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation revokeToken
    /// </summary>
    public class RevokeTokenParameters
    {
        /// <summary>
        ///     Access or refresh token to be revoked (along with the entire OAuth session).
        ///     Note: it is recommended to pass token via request body attribute
        /// </summary>
        public string token { get; set; }
    }
}