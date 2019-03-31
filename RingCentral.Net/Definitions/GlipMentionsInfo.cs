namespace RingCentral
{
    public class GlipMentionsInfo
    {
        /// <summary>
        /// Internal identifier of a user
        /// </summary>
        public string id;

        /// <summary>
        /// Type of mentions
        /// Enum: Person, Team, File, Link, Event, Task, Note, Card
        /// </summary>
        public string type;

        /// <summary>
        /// Name of a user
        /// </summary>
        public string name;
    }
}