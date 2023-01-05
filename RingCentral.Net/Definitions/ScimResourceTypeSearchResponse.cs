namespace RingCentral
{
    public class ScimResourceTypeSearchResponse
    {
        /// <summary>
        ///     Resource type list
        /// </summary>
        public ScimResourceTypeResponse[] Resources { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? itemsPerPage { get; set; }

        /// <summary>
        ///     Enum: urn:ietf:params:scim:api:messages:2.0:ListResponse
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? startIndex { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? totalResults { get; set; }
    }
}