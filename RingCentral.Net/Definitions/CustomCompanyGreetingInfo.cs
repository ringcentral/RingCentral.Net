namespace RingCentral
{
    public class CustomCompanyGreetingInfo
    {
        /* Link to an extension custom greeting */
        public string uri;

        /* Internal identifier of an answering rule */
        public string id;

        /* Type of a company greeting */
        // Enum: Company, StartRecording, StopRecording, AutomaticRecording
        public string type;

        /* Content media type in WAV/MP3 format */
        // Enum: WAV, MP3
        public string contentType;

        /* Link to a greeting content (audio file) */
        public string contentUri;

        /* Information on an answering rule that the greeting is applied to */
        public CustomGreetingAnsweringRuleInfo answeringRule;

        /* Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording' */
        public CustomCompanyGreetingLanguageInfo language;
    }
}