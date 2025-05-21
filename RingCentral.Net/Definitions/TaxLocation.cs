namespace RingCentral
{
    public class TaxLocation
    {
        /// <summary>
        ///     Internal identifier of a tax location
        ///     Required
        ///     Format: int64
        ///     Example: 981086004
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Tax location name
        ///     Required
        ///     Example: Tax_Location
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Type of the location object. Only 'TaxLocation' is currently supported for POST method
        ///     Required
        ///     Example: TaxLocation
        ///     Enum: BillingAddress, TaxLocation, Site
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Unique identifier of a tax location in the partner's system
        ///     Example: 4587834894962936
        /// </summary>
        public string externalLocationId { get; set; }

        /// <summary>
        ///     Effective date in the ISO 8601 (`YYYY-MM-DDThh:mm:ssTZD`) format, including date, time, and timezone
        ///     Format: date-time
        ///     Example: Sun Jun 05 2022 03:11:12 GMT-0700 (Pacific Daylight Time)
        /// </summary>
        public string effectiveDate { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PostalAddress address { get; set; }
    }
}