using Newtonsoft.Json;

namespace RingCentral
{
    public class CallerInfoFrom : Serializable
    {
        public string phoneNumber;
        public string name;
        public string location;
    }
}