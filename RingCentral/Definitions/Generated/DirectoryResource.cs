using Newtonsoft.Json;

namespace RingCentral
{
    public class DirectoryResource : Serializable
    {
        public Paging paging;
        public ContactResource[] records;
    }
}