using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PartyUpdateInfo : Serializable
    {
        // True if the party is muted. False - otherwise
        public bool? muted;
        // True if party is not connected to a session voice conference. False - otherwise
        public bool? standAlone;
    }
}