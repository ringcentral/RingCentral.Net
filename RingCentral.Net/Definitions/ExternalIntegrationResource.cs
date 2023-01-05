namespace RingCentral
{
    public class ExternalIntegrationResource
    {
        /// <summary>
        ///     Example: 9813
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Example: 1
        /// </summary>
        public string typeId { get; set; }

        /// <summary>
        ///     Example: External
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Example: Integration X
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Example: 1726
        /// </summary>
        public string outboundEdgeId { get; set; }
    }
}