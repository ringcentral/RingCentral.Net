namespace RingCentral
{
    public class CommStateRefConditionRequest
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
        public CommReferenceStateResource state { get; set; }
    }
}