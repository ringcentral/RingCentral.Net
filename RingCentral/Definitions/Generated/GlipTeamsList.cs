using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipTeamsList : Serializable
    {
        // List of teams
        public GlipTeamInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}