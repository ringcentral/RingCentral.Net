using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class FilterSupported : Serializable
    {
        public long? maxResults;
        public bool? supported;
    }
}