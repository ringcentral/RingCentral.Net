namespace RingCentral
{
    public class EnrollmentInput
    {
        /// <summary>
        ///     The encoding of the original audio
        ///     Required
        ///     Example: Wav
        ///     Enum: Mpeg, Mp4, Wav, Webm, Webp, Aac, Avi, Ogg
        /// </summary>
        public string encoding { get; set; }

        /// <summary>
        ///     Language spoken in the audio file.
        ///     Example: en-US
        /// </summary>
        public string languageCode { get; set; }

        /// <summary>
        ///     Base64-encoded audio file data.
        ///     Required
        ///     Example: base64EncodedAudioInput
        /// </summary>
        public string content { get; set; }

        /// <summary>
        ///     The enrollment ID to be registered. Acceptable format [a-zA-Z0-9_]+
        ///     Required
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }
    }
}