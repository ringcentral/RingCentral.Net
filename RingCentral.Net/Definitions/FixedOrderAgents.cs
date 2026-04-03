namespace RingCentral
{
    public class FixedOrderAgents
    {
        /// <summary>
        /// </summary>
        public FixedOrderAgentsExtensionInfo extension { get; set; }

        /// <summary>
        ///     Ordinal of an agent (call queue member)
        ///     Format: int32
        /// </summary>
        public long? index { get; set; }
    }
}