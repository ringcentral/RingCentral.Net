namespace RingCentral
{
    public class OnDemandResource
    {
        /// <summary>
        ///     Flag for controlling OnDemand Call Recording settings
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Retention period of a call recording, the default value is 90 days
        /// </summary>
        public long? retentionPeriod { get; set; }
    }
}