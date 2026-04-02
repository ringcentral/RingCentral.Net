namespace RingCentral
  {
      public class GetMessageForwardingInfo
      {
          /// <summary>
        /// </summary>
        public MessageStoreCallerInfoResponseTo originalSender { get; set; }

        /// <summary>
        ///     Original message creation date/time in ISO 8601 format including timezone,
            ///     for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string originalCreationTime { get; set; }
      }
  }