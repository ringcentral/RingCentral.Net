namespace RingCentral
{
    public class CommStateRefConditionResource
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: Schedule, State
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommStateReferenceResource state { get; set; }
    }
}