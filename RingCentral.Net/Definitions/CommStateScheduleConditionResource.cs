namespace RingCentral
{
    public class CommStateScheduleConditionResource
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
        public CommStateScheduleResource schedule { get; set; }
    }
}