using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Navigation : Serializable
    {
        public ResourceLink nextPage;
        public ResourceLink previousPage;
        public ResourceLink firstPage;
        public ResourceLink lastPage;
    }
}