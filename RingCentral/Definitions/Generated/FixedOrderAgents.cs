namespace RingCentral
{
    public class FixedOrderAgents : Serializable
    {
        public ExtensionInfo extension;

        // Ordinal of an agent (call queue member)
        public long? index;
    }
}