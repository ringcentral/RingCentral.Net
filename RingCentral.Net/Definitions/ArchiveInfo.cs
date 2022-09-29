namespace RingCentral
{
    public class ArchiveInfo
    {
        /// <summary>
        ///     Archive size in bytes
        ///     Format: int64
        ///     Example: 201412
        /// </summary>
        public long? size { get; set; }

        /// <summary>
        ///     Link for archive download
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}