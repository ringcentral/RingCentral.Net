namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readDirectoryFederation
    /// </summary>
    public class ReadDirectoryFederationParameters
    {
        /// <summary>
        ///     Federation types for search
        ///     Enum: All, Regular, AdminOnly
        /// </summary>
        public string types { get; set; }
    }
}