namespace RingCentral
  {
      public class CommStateScheduleConditionRequest
      {
          /// <summary>
        ///     State condition type
        ///     Required
        ///     Enum: Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommStateScheduleRequest schedule { get; set; }
      }
  }