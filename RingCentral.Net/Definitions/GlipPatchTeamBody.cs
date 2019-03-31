namespace RingCentral
{
    public class GlipPatchTeamBody
    {
        /* Team access level */
        public bool? @public;

        /* Team name. Maximum number of characters supported is 250 */
        public string name;

        /* Team description. Maximum number of characters supported is 1000 */
        public string description;
    }
}