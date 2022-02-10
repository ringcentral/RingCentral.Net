namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createIVRPrompt
    /// </summary>
    public class CreateIVRPromptRequest
    {
        /// <summary>
        ///     Audio file that will be used as a prompt. Attachment cannot be empty, only audio files are supported
        ///     Required
        /// </summary>
        public Attachment attachment { get; set; }

        /// <summary>
        ///     Description of file contents.
        /// </summary>
        public string name { get; set; }
    }
}