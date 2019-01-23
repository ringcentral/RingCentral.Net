namespace RingCentral
{
    public class DisabledFilterInfo : Serializable
    {
        // Event filter that is disabled for the user
        public string filter;

        // Reason why the filter is disabled for the user
        public string reason;

        // Error message
        public string message;
    }
}