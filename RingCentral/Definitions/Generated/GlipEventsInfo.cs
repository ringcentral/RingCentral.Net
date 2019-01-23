using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipEventsInfo : Serializable
    {
        // List of events created by the current user
        public GlipEventInfo[] records;
        public GlipNavigationInfo navigation;
    }
}