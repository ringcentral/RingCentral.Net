namespace RingCentral
{
    public class QueueShortInfoResource
    {
        /// <summary>
        ///     Call queue extension identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Call queue name (read-only)
        /// </summary>
        public string name { get; set; }
    }
}