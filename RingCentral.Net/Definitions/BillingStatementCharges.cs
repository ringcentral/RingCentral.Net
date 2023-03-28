namespace RingCentral
{
    public class BillingStatementCharges
    {
        /// <summary>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Format: double
        /// </summary>
        public decimal? amount { get; set; }

        /// <summary>
        /// </summary>
        public string feature { get; set; }

        /// <summary>
        ///     Format: double
        /// </summary>
        public decimal? freeServiceCredit { get; set; }
    }
}