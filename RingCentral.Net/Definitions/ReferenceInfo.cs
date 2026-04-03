namespace RingCentral
{
    public class ReferenceInfo
    {
        /// <summary>
        ///     Non-RC identifier of an extension
        /// </summary>
        public string @ref { get; set; }

        /// <summary>
        ///     Type of external identifier
        ///     Enum: PartnerId, CustomerDirectoryId
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Primary federation admin account identifier
        /// </summary>
        public string refAccId { get; set; }
    }
}