using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipTeamsList : Serializable
    {
        // List of teams
        public GlipTeamInfo[] records;
        public GlipNavigationInfo navigation;
    }
}