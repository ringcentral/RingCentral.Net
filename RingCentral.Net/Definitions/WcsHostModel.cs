namespace RingCentral
{
    /// <summary>
    ///     The internal IDs of RC-authenticated users.
    /// </summary>
    public class WcsHostModel
    {
        /// <summary>
        ///     Describes host's license, 'true' - license is active
        ///     Required
        /// </summary>
        public bool? entitled { get; set; }

        /// <summary>
        ///     User ID
        ///     Required
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        ///     Account ID
        ///     Required
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// </summary>
        public RcwDomainUserModel linkedUser { get; set; }
    }
}