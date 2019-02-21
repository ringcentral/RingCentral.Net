namespace RingCentral
{
    public class GlipPostTeamBody
    {
        // Team access level.
        public bool? @public;

        // Team name.
        public string name; // Required

        // Team description.
        public string description;

        // Identifier(s) of team members.
        public object[] members;
    }
}