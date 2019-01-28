namespace RingCentral
{
    public class UserSearchResponse
    {
        // user list
        public UserResponse[] Resources;
        public long? itemsPerPage;
        public string[] schemas;
        public long? startIndex;
        public long? totalResults;
    }
}