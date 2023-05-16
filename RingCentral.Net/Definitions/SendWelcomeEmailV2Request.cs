namespace RingCentral
{
    /// <summary>
    ///     Request body for operation sendWelcomeEmailV2
    /// </summary>
    public class SendWelcomeEmailV2Request
    {
        /// <summary>
        ///     Format: email
        ///     Example: user@email.com
        /// </summary>
        public string email { get; set; }
    }
}