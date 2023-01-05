namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation scimSearchViaGet2
    /// </summary>
    public class ScimSearchViaGet2Parameters
    {
        /// <summary>
        ///     Only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter { get; set; }

        /// <summary>
        ///     Start index (1-based)
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? startIndex { get; set; }

        /// <summary>
        ///     Page size
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? count { get; set; }
    }
}