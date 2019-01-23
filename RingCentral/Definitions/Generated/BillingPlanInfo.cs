namespace RingCentral
{
    public class BillingPlanInfo : Serializable
    {
        // Internal identifier of a billing plan
        public string id;

        // Billing plan name
        public string name;

        // Duration period
        // Enum: Month, Day
        public string durationUnit;

        // Number of duration units
        public string duration;

        // Billing plan type
        // Enum: Initial, Regular, Suspended, Trial, TrialNoCC, Free
        public string type;
    }
}