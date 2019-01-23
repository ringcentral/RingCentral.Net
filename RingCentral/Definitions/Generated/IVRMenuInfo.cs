namespace RingCentral
{
    public class IVRMenuInfo : Serializable
    {
        // Internal identifier of an IVR Menu extension
        public string id;

        // Link to an IVR Menu extension resource
        public string uri;

        // First name of an IVR Menu user
        public string name;

        // Number of an IVR Menu extension
        public string extensionNumber;

        // Prompt metadata
        public IVRMenuPromptInfo prompt;

        // Keys handling settings
        public IVRMenuActionsInfo[] actions;
    }
}