namespace RingCentral
{
    // Information on account billing plan
    public class BillingPlanInfo
    {
        /// <summary>
        /// Internal identifier of a billing plan
        /// </summary>
        public string id;

        /// <summary>
        /// Billing plan name
        /// </summary>
        public string name;

        /// <summary>
        /// Duration period
        /// Enum: Month, Day
        /// </summary>
        public string durationUnit;

        /// <summary>
        /// Number of duration units
        /// </summary>
        public long? duration;

        /// <summary>
        /// Billing plan type
        /// Enum: Initial, Regular, Suspended, Trial, TrialNoCC, Free
        /// </summary>
        public string type;

        /// <summary>
        /// Included digital lines count
        /// </summary>
        public long? includedPhoneLines;
    }
}