using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipPersonInfo : Serializable
    {
        // Internal identifier of a user
        public string id; // Required
        // First name of a user
        public string firstName;
        // Last name of a user
        public string lastName;
        // Email of a user
        public string email;
        // Photo of a user
        public string avatar;
        // Internal identifier of a company
        public string companyId;
        // Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime;
        // Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime;
    }
}