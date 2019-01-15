using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ErrorResponse : Serializable
    {
        // Collection of all gathered errors
        public Error[] errors;
    }
}