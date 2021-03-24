namespace RingCentral
{
    public class SearchRequest
    {
        /// <summary>
        /// page size
        /// Format: int32
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        /// only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter { get; set; }

        /// <summary>
        /// Enum: urn:ietf:params:scim:api:messages:2.0:SearchRequest
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        /// start index (1-based)
        /// Format: int32
        /// </summary>
        public long? startIndex { get; set; }
    }
}