using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipTeamsList : Serializable
    {
        // List of teams
        public GlipTeamInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}