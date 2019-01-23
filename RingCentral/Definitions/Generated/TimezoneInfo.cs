namespace RingCentral
{
    public class TimezoneInfo : Serializable
    {
        // Internal identifier of a timezone
        public string id;
        // Canonical URI of a timezone
        public string uri;
        // Short name of a timezone
        public string name;
        // Meaningful description of the timezone
        public string description;
    }
}