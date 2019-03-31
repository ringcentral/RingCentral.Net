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