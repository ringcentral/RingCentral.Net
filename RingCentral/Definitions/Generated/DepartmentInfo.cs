using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class DepartmentInfo : Serializable
    {
        // Internal identifier of a department extension
        public string id;
        // Canonical URI of a department extension
        public string uri;
        // Number of a department extension
        public string extensionNumber;
    }
}