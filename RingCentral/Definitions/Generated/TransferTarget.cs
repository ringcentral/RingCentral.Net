using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class TransferTarget : Serializable
    {
        // Phone number
        public string phoneNumber;
        // VM owner's extension id
        public string voicemail;
        // Park orbit id
        public string parkOrbit;
    }
}