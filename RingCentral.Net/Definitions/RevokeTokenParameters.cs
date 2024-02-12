namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation revokeToken
    /// </summary>
    public class RevokeTokenParameters
    {
        /// <summary>
        ///     Access or refresh token to be revoked (along with the entire OAuth session)
        /// </summary>
        public string token { get; set; }
    }
}