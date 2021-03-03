namespace RingCentral
{
    // Information on account billing plan
    public class BillingPlanInfo
    {
        /// <summary>
        /// Internal identifier of a billing plan
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Billing plan name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Duration period
        /// Enum: Day, Month, Year
        /// </summary>
        public string durationUnit { get; set; }

        /// <summary>
        /// Number of duration units
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        /// Billing plan type
        /// Enum: Initial, Regular, Suspended, Trial, TrialNoCC, Free
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Included digital lines count
        /// </summary>
        public long? includedPhoneLines { get; set; }
    }
}