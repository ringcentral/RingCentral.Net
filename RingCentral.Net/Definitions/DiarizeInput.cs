namespace RingCentral
{
    public class DiarizeInput
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

        /// <summary>
        ///     Set to True if the input audio is multi-channel and each channel has a separate speaker.
        /// </summary>
        public bool? separateSpeakerPerChannel { get; set; }

        /// <summary>
        ///     Number of speakers in the file, omit parameter if unknown
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        ///     Optional set of speakers to be identified from the call.
        ///     Example: speakerId1,speakerId2
        /// </summary>
        public string[] speakerIds { get; set; }

        /// <summary>
        ///     Apply voice activity detection.
        /// </summary>
        public bool? enableVoiceActivityDetection { get; set; }
    }
}