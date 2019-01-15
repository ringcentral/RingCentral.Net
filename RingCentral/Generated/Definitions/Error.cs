using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Error : Serializable
    {
        // Code that characterizes this error. Code uniqly identifies the source of the error.
        public string errorCode;
        // Message that describes the error. This message can be used in UI.
        public string message;
    }
}