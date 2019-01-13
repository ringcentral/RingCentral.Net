using Newtonsoft.Json;

namespace RingCentral
{
    public class FilterSupported : Serializable
    {
        public int? maxResults;
        public bool? supported;
    }
}