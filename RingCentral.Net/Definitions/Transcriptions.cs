namespace RingCentral
  {
    /// <summary>
/// This objects denotes availability of transcription of certain type as post meeting artefact. The trancript's
/// content can be accessed via via POST '/rcvideo/v1/history/meetings/{meetingId}/access-materials'
/// or POST '/rcvideo/v1/history/links' APIs
/// 
/// </summary>
      public class Transcriptions
      {
          /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: LiveTranscription
        /// </summary>
        public string type { get; set; }
      }
  }