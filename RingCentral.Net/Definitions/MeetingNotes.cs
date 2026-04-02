namespace RingCentral
  {
    /// <summary>
/// This objects denotes availability of AI generated meeting notes of certain type as post meeting artefact. 
/// The note's content can be accessed via POST '/rcvideo/v1/history/meetings/{meetingId}/access-materials'
/// or POST '/rcvideo/v1/history/links' APIs
/// 
/// </summary>
      public class MeetingNotes
      {
          /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: GeneratedNotes
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Generated notes processing status `Processing` - meeting is finished and generated notes haven't been processed yet `Processed` -  generated notes successfully processed `Failed` - generated notes processing finished with error `Purged` - generated notes were removed
        ///     Required
        ///     Enum: Processing, Processed, Purged, Failed
        /// </summary>
        public string status { get; set; }
      }
  }