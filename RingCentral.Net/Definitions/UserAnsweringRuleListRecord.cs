namespace RingCentral
{
    public class UserAnsweringRuleListRecord
    {
        /* Canonical URI to an answering rule resource */
        public string uri;

        /* Internal identifier of an asnwering rule */
        public string id;

        /* Type of an answering rule */
        // Enum: BusinessHours, AfterHours, Custom
        public string type;

        /* Name of an answering rule specified by user */
        public string name;

        /* Specifies if an answering rule is active or inactive */
        public bool? enabled;
    }
}