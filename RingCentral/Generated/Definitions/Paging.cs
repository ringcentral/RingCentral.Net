using Newtonsoft.Json;

namespace RingCentral
{
    public class Paging : Serializable
    {
        public long? page;
        public long? totalPages;
        public long? perPage;
        public long? totalElements;
        public long? pageStart;
        public long? pageEnd;
    }
}