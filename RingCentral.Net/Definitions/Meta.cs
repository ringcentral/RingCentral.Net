namespace RingCentral
{
    /// <summary>
    ///     resource metadata
    /// </summary>
    public class Meta
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
        ///     resource location URI
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Enum: User, Group
        /// </summary>
        public string resourceType { get; set; }
    }
}