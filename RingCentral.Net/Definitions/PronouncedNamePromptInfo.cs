namespace RingCentral
{
    public class PronouncedNamePromptInfo
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link to a prompt resource
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        /// Content media type
        /// Enum: audio/mpeg, audio/wav
        /// </summary>
        public string contentType { get; set; }
    }
}