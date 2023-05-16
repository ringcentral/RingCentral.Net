namespace RingCentral
{
    public class AudioInput
    {
        /// <summary>
        ///     Publicly facing uri
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     The encoding of the original audio
        ///     Required
        ///     Example: Wav
        ///     Enum: Mpeg, Mp4, Wav, Webm, Webp, Aac, Avi, Ogg
        /// </summary>
        public string encoding { get; set; }

        /// <summary>
        ///     Language spoken in the audio file.
        ///     Required
        ///     Example: en-US
        /// </summary>
        public string languageCode { get; set; }

        /// <summary>
        ///     Source of the audio file eg: Phone, RingCentral, GoogleMeet, Zoom etc
        ///     Example: RingCentral
        /// </summary>
        public string source { get; set; }

        /// <summary>
        ///     Type of the audio
        ///     Example: CallCenter
        ///     Enum: CallCenter, Meeting, EarningsCalls, Interview, PressConference, Voicemail
        /// </summary>
        public string audioType { get; set; }
    }
}