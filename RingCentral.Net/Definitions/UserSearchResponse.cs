namespace RingCentral
{
    public class UserSearchResponse
    {
        /// <summary>
        /// user list
        /// </summary>
        public UserResponse[] Resources;

        /// <summary>
        /// </summary>
        public long? itemsPerPage;

        /// <summary>
        /// Enum: urn:ietf:params:scim:api:messages:2.0:ListResponse
        /// </summary>
        public string[] schemas;

        /// <summary>
        /// </summary>
        public long? startIndex;

        /// <summary>
        /// </summary>
        public long? totalResults;
    }
}