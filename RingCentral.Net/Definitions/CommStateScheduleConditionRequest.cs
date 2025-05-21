namespace RingCentral
{
    public class CommStateScheduleConditionRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommStateScheduleResource schedule { get; set; }
    }
}