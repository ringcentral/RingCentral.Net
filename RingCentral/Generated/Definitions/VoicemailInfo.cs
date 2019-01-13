using Newtonsoft.Json;

namespace RingCentral
{
    public class VoicemailInfo : Serializable
    {
        // If 'True' then voicemails are allowed to be received
        public bool? enabled;
        // Recipient data
        public RecipientInfo recipient;
    }
}