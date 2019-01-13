using Newtonsoft.Json;

namespace RingCentral
{
    public class BulkSupported : Serializable
    {
        public int? maxOperations;
        public int? maxPayloadSize;
        public bool? supported;
    }
}