namespace RingCentral
{
    /// <summary>
    ///     Request body for operation introspectToken
    /// </summary>
    public class IntrospectTokenRequest
    {
        /// <summary>
        ///     OAuth token
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// </summary>
        public string scope { get; set; }
    }
}