namespace RingCentral
{
    public class CommInteractionDispatchingResource
    {
        /// <summary>
        /// </summary>
        public CommCallTypesResource callTypes { get; set; }

        /// <summary>
        ///     Action information
        ///     Required
        /// </summary>
        public CommInteractionDispatchingResourceActions[] actions { get; set; }

        /// <summary>
        ///     Call dispatching type
        ///     Required
        ///     Enum: RingAtOnce, RingInOrder, Custom, Terminate
        /// </summary>
        public string type { get; set; }
    }
}