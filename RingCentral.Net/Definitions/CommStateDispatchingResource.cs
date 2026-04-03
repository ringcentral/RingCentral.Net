namespace RingCentral
{
    public class CommStateDispatchingResource
    {
        /// <summary>
        ///     Action information
        ///     Required
        /// </summary>
        public CommStateDispatchingResourceActions[] actions { get; set; }

        /// <summary>
        ///     Call dispatching type
        ///     Required
        ///     Enum: RingAtOnce, RingInOrder, Custom, Terminate
        /// </summary>
        public string type { get; set; }
    }
}