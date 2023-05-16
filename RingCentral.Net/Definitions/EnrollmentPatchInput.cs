namespace RingCentral
{
    public class EnrollmentPatchInput
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
    }
}