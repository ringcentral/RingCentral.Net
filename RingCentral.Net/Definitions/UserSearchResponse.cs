namespace RingCentral
{
    public class UserSearchResponse
    {
        /// <summary>
        /// user list
        /// </summary>
        public UserResponse[] Resources { get; set; }

        /// <summary>
        /// Format: int64
        /// </summary>
        public long? itemsPerPage { get; set; }

        /// <summary>
        /// Enum: urn:ietf:params:scim:api:messages:2.0:ListResponse
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        /// Format: int64
        /// </summary>
        public long? startIndex { get; set; }

        /// <summary>
        /// Format: int64
        /// </summary>
        public long? totalResults { get; set; }
    }
}