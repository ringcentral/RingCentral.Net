namespace RingCentral
{
    // Deprecated. Information on call owner
    public class OwnerInfo
    {
        /// <summary>
        /// Internal identifier of an account that monitors a call
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// Internal identifier of an extension that monitors a call
        /// </summary>
        public string extensionId { get; set; }
    }
}