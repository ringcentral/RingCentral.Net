namespace RingCentral
{
    public class ArchiveInfo
    {
        /// <summary>
        ///     Archive size in bytes
        /// </summary>
        public long? size { get; set; }

        /// <summary>
        ///     Link for archive download
        /// </summary>
        public string uri { get; set; }
    }
}