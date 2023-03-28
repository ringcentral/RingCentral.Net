namespace RingCentral
{
    public class SiteMemberInfo
    {
        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}