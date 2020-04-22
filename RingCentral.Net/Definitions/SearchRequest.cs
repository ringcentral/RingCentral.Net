namespace RingCentral
{
    public class SearchRequest
    {
        /// <summary>
        /// page size
        /// </summary>
        public long? count;

        /// <summary>
        /// only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter;

        /// <summary>
        /// Enum: urn:ietf:params:scim:api:messages:2.0:SearchRequest
        /// </summary>
        public string[] schemas;

        /// <summary>
        /// start index (1-based)
        /// </summary>
        public long? startIndex;
    }
}