namespace RingCentral
{
    public class GlipPostEvent
    {
        // Internal identifier of a post
        public string id;

        // Type of a post event
        // Enum: PostAdded, PostChanged, PostRemoved
        public string eventType;

        // Internal identifier of a group a post belongs to
        public string groupId;

        // Type of a post. 'TextMessage' - an incoming text message; 'PersonJoined' - a message notifying that person has joined a conversation; 'PersonsAdded' - a message notifying that a person(s) were added to a conversation
        // Enum: TextMessage, PersonJoined, PersonsAdded, Card
        public string type;

        // For 'TextMessage' post type only. Message text
        public string text;

        // Internal identifier of a user - author of a post
        public string creatorId;

        // For PersonsAdded post type only. Identifiers of persons added to a group
        public string[] addedPersonIds;

        // For PersonsRemoved post type only. Identifiers of persons removed from a group
        public string[] removedPersonIds;

        // List of at mentions in post text with names.
        public GlipMentionsInfo[] mentions;

        // Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime;

        // Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime;
    }
}