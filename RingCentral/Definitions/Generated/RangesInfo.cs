using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RangesInfo : Serializable
    {
        // Starting datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601), for example *2018-10-29T14:00:00*, *2018-10-29T14:00:00Z*, *2018-10-29T14:00:00+0100*
        public string from;
        // Ending datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601), for example *2018-10-29T14:00:00*, *2018-10-29T14:00:00Z*, *2018-10-29T14:00:00+0100*
        public string to;
    }
}