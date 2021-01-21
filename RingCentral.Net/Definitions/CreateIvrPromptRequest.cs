namespace RingCentral
{
    public class CreateIvrPromptRequest
    {
        /// <summary>
        /// Audio file that will be used as a prompt. Attachment cannot be empty, only audio files are supported
        /// </summary>
        public Attachment attachment { get; set; }

        /// <summary>
        /// Description of file contents.
        /// </summary>
        public string name { get; set; }
    }
}