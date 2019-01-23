namespace RingCentral
{
    public class GlipMentionsInfo : Serializable
    {
        // Internal identifier of a user
        public string id;

        // Type of mentions
        // Enum: Person, Team, File, Link, Event, Task, Note, Card
        public string type;

        // Name of a user
        public string name;
    }
}