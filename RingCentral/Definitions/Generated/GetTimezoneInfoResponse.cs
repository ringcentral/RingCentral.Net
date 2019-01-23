namespace RingCentral
{
    public class GetTimezoneInfoResponse : Serializable
    {
        // Internal identifier of a timezone
        public string id;

        // Canonical URI of a timezone
        public string uri;

        // Short name of a timezone
        public string name;

        // Description of a timezone
        public string description;
    }
}