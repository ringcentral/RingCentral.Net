namespace RingCentral
{
    public class UserSearchResponse : Serializable
    {
        // user list
        public UserResponse[] Resources;
        public long? itemsPerPage;
        public string[] schemas;
        public long? startIndex;
        public long? totalResults;
    }
}