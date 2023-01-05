namespace RingCentral
{
    /// <summary>
    ///     Resource metadata
    /// </summary>
    public class ScimMeta
    {
        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string created { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string lastModified { get; set; }

        /// <summary>
        ///     Resource location URI
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Enum: User, Group, ResourceType, Schema
        /// </summary>
        public string resourceType { get; set; }
    }
}