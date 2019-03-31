namespace RingCentral
{
    public class IVRMenuInfo
    {
        /// <summary>
        /// Internal identifier of an IVR Menu extension
        /// </summary>
        public string id;

        /// <summary>
        /// Link to an IVR Menu extension resource
        /// </summary>
        public string uri;

        /// <summary>
        /// First name of an IVR Menu user
        /// </summary>
        public string name;

        /// <summary>
        /// Number of an IVR Menu extension
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Prompt metadata
        /// </summary>
        public IVRMenuPromptInfo prompt;

        /// <summary>
        /// Keys handling settings
        /// </summary>
        public IVRMenuActionsInfo[] actions;
    }
}