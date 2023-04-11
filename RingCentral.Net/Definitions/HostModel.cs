namespace RingCentral
{
    /// <summary>
    ///     The internal IDs of RC-authenticated users.
    /// </summary>
    public class HostModel
    {
        /// <summary>
        ///     First (given) name
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last (family) name
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// </summary>
        public RcwDomainUserModel linkedUser { get; set; }
    }
}