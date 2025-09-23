namespace RingCentral
{
    /// <summary>
    ///     Deprecated. Information on a call owner
    /// </summary>
    public class OwnerInfo
    {
        /// <summary>
        ///     Internal identifier of an account that monitors a call
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension that monitors a call
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Internal identifier of an account brandId that monitors a call
        /// </summary>
        public string brandId { get; set; }
    }
}