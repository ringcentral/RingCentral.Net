namespace RingCentral
  {
    /// <summary>
/// Phone Number Parser service's Parse Phone Numbers API 4xx error response schema.
/// </summary>
      public class ClientErrorsResponse
      {
          /// <summary>
        ///     Required
        /// </summary>
        public ClientErrorsResponseErrors[] errors { get; set; }
      }
  }