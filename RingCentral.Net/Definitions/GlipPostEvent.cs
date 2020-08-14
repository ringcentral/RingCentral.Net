namespace RingCentral
{
    public class GlipPostEvent
    {
        /// <summary>
        /// Internal identifier of a post
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a post event
        /// Enum: PostAdded, PostChanged, PostRemoved
        /// </summary>
        public string eventType;

        /// <summary>
        /// Internal identifier of a group a post belongs to
        /// </summary>
        public string groupId;

        /// <summary>
        /// Type of a post. 'TextMessage' - an incoming text message; 'PersonJoined' - a message notifying that person has joined a conversation; 'PersonsAdded' - a message notifying that a person(s) were added to a conversation
        /// Enum: TextMessage, PersonJoined, PersonsAdded, Card
        /// </summary>
        public string type;

        /// <summary>
        /// For 'TextMessage' post type only. Message text
        /// </summary>
        public string text;

        /// <summary>
        /// Internal identifier of a user - author of a post
        /// </summary>
        public string creatorId;

        /// <summary>
        /// For PersonsAdded post type only. Identifiers of persons added to a group
        /// </summary>
        public string[] addedPersonIds;

        /// <summary>
        /// For PersonsRemoved post type only. Identifiers of persons removed from a group
        /// </summary>
        public string[] removedPersonIds;

        /// <summary>
        /// List of at mentions in post text with names.
        /// </summary>
        public GlipMentionsInfo[] mentions;

        /// <summary>
        /// Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime;
    }
}