namespace RingCentral
{
    public class GlipPostEvent
    {
        /// <summary>
        /// Internal identifier of a post
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of a post event
        /// Enum: PostAdded, PostChanged, PostRemoved
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        /// Internal identifier of a group a post belongs to
        /// </summary>
        public string groupId { get; set; }

        /// <summary>
        /// Type of a post. 'TextMessage' - an incoming text message; 'PersonJoined' - a message notifying that person has joined a conversation; 'PersonsAdded' - a message notifying that a person(s) were added to a conversation
        /// Enum: TextMessage, PersonJoined, PersonsAdded, Card
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// For 'TextMessage' post type only. Message text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Internal identifier of a user - author of a post
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// For PersonsAdded post type only. Identifiers of persons added to a group
        /// </summary>
        public string[] addedPersonIds { get; set; }

        /// <summary>
        /// For PersonsRemoved post type only. Identifiers of persons removed from a group
        /// </summary>
        public string[] removedPersonIds { get; set; }

        /// <summary>
        /// List of at mentions in post text with names.
        /// </summary>
        public GlipMentionsInfo[] mentions { get; set; }

        /// <summary>
        /// Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}