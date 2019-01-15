using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class DirectoryResource : Serializable
    {
        public Paging paging;
        public ContactResource[] records;
    }
}