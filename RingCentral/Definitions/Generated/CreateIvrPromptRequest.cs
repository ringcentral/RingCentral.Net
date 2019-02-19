namespace RingCentral
{
    public class CreateIvrPromptRequest
    {
        // Audio file that will be used as a prompt. Attachment cannot be empty, only audio files are supported
        public Attachment attachment;

        // Description of file contents.
        public string name;
    }
}