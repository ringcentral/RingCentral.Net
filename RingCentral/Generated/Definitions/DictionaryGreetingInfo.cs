using Newtonsoft.Json;

namespace RingCentral
{
    public class DictionaryGreetingInfo : Serializable
    {
        // Internal identifier of a greeting
        public string id;
        // Link to a greeting
        public string uri;
        // Name of a greeting
        public string name;
        // Usage type of a greeting, specifying if the greeting is applied for user extension or department extension.
        public string usageType;
        // Text of a greeting, if any
        public string text;
        // Link to a greeting content (audio file), if any
        public string contentUri;
        // Type of a greeting, specifying the case when the greeting is played.
        public string type;
        // Category of a greeting, specifying data form. The category value 'None' specifies that greetings of a certain type ('Introductory', 'ConnectingAudio', etc.) are switched off for an extension = ['Music', 'Message', 'RingTones', 'None']
        public string category;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}