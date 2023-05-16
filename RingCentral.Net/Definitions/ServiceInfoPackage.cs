namespace RingCentral
{
    /// <summary>
    ///     Billing package information
    /// </summary>
    public class ServiceInfoPackage
    {
        /// <summary>
        ///     Billing package ID
        ///     Required
        ///     Example: 555
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Billing package version
        ///     Required
        ///     Enum: 1
        /// </summary>
        public string version { get; set; }
    }
}