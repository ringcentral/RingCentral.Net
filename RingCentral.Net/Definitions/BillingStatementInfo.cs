namespace RingCentral
{
    // Billing information. Returned for device update request if `prestatement` query parameter is set to 'true'
    public class BillingStatementInfo
    {
        /// <summary>
        ///     Currency code complying with [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) standard
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// </summary>
        public BillingStatementCharges[] charges { get; set; }

        /// <summary>
        /// </summary>
        public BillingStatementFees[] fees { get; set; }

        /// <summary>
        /// </summary>
        public decimal? totalCharged { get; set; }

        /// <summary>
        /// </summary>
        public decimal? totalCharges { get; set; }

        /// <summary>
        /// </summary>
        public decimal? totalFees { get; set; }

        /// <summary>
        /// </summary>
        public decimal? subtotal { get; set; }

        /// <summary>
        /// </summary>
        public decimal? totalFreeServiceCredit { get; set; }
    }
}