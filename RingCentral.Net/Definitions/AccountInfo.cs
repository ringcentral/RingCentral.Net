namespace RingCentral
{
    public class AccountInfo
    {
        /// <summary>
        ///     Internal identifier of RingCentral account
        ///     Required
        ///     Example: 8000012345
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     External account ID. Used as a primary key to link accounts between
        ///     RingCentral and partner systems.
        ///     Example: acme-us-12345
        /// </summary>
        public string externalAccountId { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string mainNumber { get; set; }

        /// <summary>
        ///     Account status
        ///     Required
        ///     Example: Confirmed
        ///     Enum: Initial, Unconfirmed, Confirmed, Disabled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public AccountStatusInfo statusInfo { get; set; }

        /// <summary>
        ///     Company name
        ///     Example: Acme Inc.
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// </summary>
        public PostalAddress companyAddress { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ServiceInfoV2 serviceInfo { get; set; }

        /// <summary>
        /// </summary>
        public SystemUserContactInfo contactInfo { get; set; }

        /// <summary>
        ///     Opportunity identifier (typically created by SalesForce)
        ///     Example: 0061800000DwZzJAAV
        /// </summary>
        public string opportunityId { get; set; }
    }
}