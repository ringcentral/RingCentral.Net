namespace RingCentral
{
    // Billing information. Returned for device update request if `prestatement` query parameter is set to 'true'
    public class BillingStatementInfo
    {
        /// <summary>
        /// Currency code complying with [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) standard
        /// </summary>
        public string currency;

        /// <summary>
        /// </summary>
        public BillingStatementCharges[] charges;

        /// <summary>
        /// </summary>
        public BillingStatementFees[] fees;

        /// <summary>
        /// </summary>
        public decimal? totalCharged;

        /// <summary>
        /// </summary>
        public decimal? totalCharges;

        /// <summary>
        /// </summary>
        public decimal? totalFees;

        /// <summary>
        /// </summary>
        public decimal? subtotal;

        /// <summary>
        /// </summary>
        public decimal? totalFreeServiceCredit;
    }
}