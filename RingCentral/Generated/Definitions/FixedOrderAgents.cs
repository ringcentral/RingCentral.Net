using Newtonsoft.Json;

namespace RingCentral
{
    public class FixedOrderAgents : Serializable
    {
        public ExtensionInfo extension;
        // Ordinal of an agent (call queue member)
        public int? index;
    }
}