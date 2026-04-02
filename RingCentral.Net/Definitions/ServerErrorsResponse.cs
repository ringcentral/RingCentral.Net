namespace RingCentral
  {
    /// <summary>
/// Phone Number Parser service's Parse Phone Numbers API 5xx error response schema.
/// </summary>
      public class ServerErrorsResponse
      {
          /// <summary>
        ///     Required
        /// </summary>
        public ServerErrorsResponseErrors[] errors { get; set; }
      }
  }