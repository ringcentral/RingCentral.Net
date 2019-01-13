using Newtonsoft.Json;

namespace RingCentral
{
    public class CallerInfoTo : Serializable
    {
        public string phoneNumber;
        public string name;
        public string location;
        public string messageStatus;
        public string faxErrorCode;
    }
}