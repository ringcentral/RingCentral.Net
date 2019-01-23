namespace RingCentral
{
    public class GlipMessageAttachmentAuthorInfo : Serializable
    {
        // Name of a message author
        public string name;
        // Link to an author's name
        public string uri;
        // Link to an image displayed to the left of an author's name; sized 82x82px
        public string iconUri;
    }
}