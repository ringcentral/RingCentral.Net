using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipNotesInfo : Serializable
    {
        public GlipNoteInfo[] records;
        public GlipNavigationInfo navigation;
    }
}