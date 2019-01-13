using Newtonsoft.Json;

namespace RingCentral
{
    public class SearchRequest : Serializable
    {
        // page size
        public int? count;
        // only support 'userName' or 'email' filter expressions for now
        public string filter;
        public string[] schemas;
        // start index (1-based)
        public int? startIndex;
    }
}