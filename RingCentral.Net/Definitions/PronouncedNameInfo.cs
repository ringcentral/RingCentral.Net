namespace RingCentral
{
    public class PronouncedNameInfo
    {
        /// <summary>
        ///     Voice name type. 'Default' - default extension name; first name and last name specified in user profile;
        ///     'TextToSpeech' - custom text; user name spelled the way it sounds and specified by user; 'Recorded' - custom audio,
        ///     user name recorded in user's own voice (supported only for extension retrieval)
        ///     Enum: Default, TextToSpeech, Recorded
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Custom text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// </summary>
        public PronouncedNamePromptInfo prompt { get; set; }
    }
}