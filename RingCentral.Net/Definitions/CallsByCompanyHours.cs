namespace RingCentral
{
    public class CallsByCompanyHours
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? businessHours { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? afterHours { get; set; }
    }
}