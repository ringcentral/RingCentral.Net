using Newtonsoft.Json;

namespace RingCentral
{
    public class UserSearchResponse : Serializable
    {
        // user list
        public UserResponse[] Resources;
        public int? itemsPerPage;
        public string[] schemas;
        public int? startIndex;
        public int? totalResults;
    }
}