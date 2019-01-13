using Newtonsoft.Json;

namespace RingCentral
{
    public class Paging : Serializable
    {
        public int? page;
        public int? totalPages;
        public int? perPage;
        public int? totalElements;
        public int? pageStart;
        public int? pageEnd;
    }
}