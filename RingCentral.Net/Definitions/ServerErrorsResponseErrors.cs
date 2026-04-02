namespace RingCentral
  {
      public class ServerErrorsResponseErrors
      {
          /// <summary>
        ///     Logical error code.
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Detailed user-friendly description of error.
        /// </summary>
        public string message { get; set; }
      }
  }