namespace RingCentral
{
    public class BillingStatementFees
    {
        /// <summary>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Format: double
        /// </summary>
        public decimal? amount { get; set; }

        /// <summary>
        ///     Format: double
        /// </summary>
        public decimal? freeServiceCredit { get; set; }
    }
}