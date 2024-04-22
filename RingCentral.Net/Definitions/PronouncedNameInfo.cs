namespace RingCentral
{
    public class PronouncedNameInfo
    {
        /// <summary>
        ///     The method used to pronounce the user's name:
        ///     - `Default` - default extension name; first and last name specified in user's profile are pronounced using
        ///     text-to-speech;
        ///     - `TextToSpeech` - custom text specified by a user  pronounced using text-to-speech;
        ///     - `Recorded` - custom audio uploaded by a user, the name recorded in user's own voice (supported only for extension
        ///     retrieval).
        ///     Enum: Default, TextToSpeech, Recorded
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Custom text (for `TextToSpeech` type only)
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// </summary>
        public PronouncedNamePromptInfo prompt { get; set; }
    }
}