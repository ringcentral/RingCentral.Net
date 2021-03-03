namespace RingCentral
{
    public class GlipMentionsInfo
    {
        /// <summary>
        /// Internal identifier of a user
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of mention
        /// Enum: Person, Team, File, Link, Event, Task, Note, Card
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Name of a user
        /// </summary>
        public string name { get; set; }
    }
}