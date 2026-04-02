namespace RingCentral
  {
      public class CallQueueMemberPresence
      {
          /// <summary>
        /// </summary>
        public CallQueueMember member { get; set; }

        /// <summary>
        ///     Private member telephony availability status applied to calls
            ///     of all queues. Please note - this parameter can be passed in request body,
            ///     but will be ignored
        /// </summary>
        public bool? acceptQueueCalls { get; set; }

        /// <summary>
        ///     Call queue member availability in this particular queue
        /// </summary>
        public bool? acceptCurrentQueueCalls { get; set; }
      }
  }