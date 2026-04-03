namespace RingCentral
{
    public class FederationResource
    {
        /// <summary>
        /// </summary>
        public FederatedAccountResource[] accounts { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Federation type
        ///     Enum: Regular, AdminOnly
        /// </summary>
        public string type { get; set; }
    }
}