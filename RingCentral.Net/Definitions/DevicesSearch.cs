namespace RingCentral
{
    public class DevicesSearch
    {
        /// <summary>
        ///     String value to filter the devices. Should being found by fields name, extensionName, phoneNumber, serial,
        ///     extensionNumber
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Filtering by order status.
        ///     Enum: InProgress, PendingReplacement, Delivered
        /// </summary>
        public string[] orderStatuses { get; set; }

        /// <summary>
        ///     Internal identifiers of the business sites to which devices belong.
        /// </summary>
        public string[] siteIds { get; set; }

        /// <summary>
        ///     Internal identifiers (codes) of the device types
        /// </summary>
        public string[] types { get; set; }

        /// <summary>
        ///     Internal identifiers (codes) of the device types to exclude from the response
        /// </summary>
        public string[] excludeTypes { get; set; }

        /// <summary>
        ///     A list of Country IDs
        /// </summary>
        public string[] countryIds { get; set; }

        /// <summary>
        ///     A list of area codes
        /// </summary>
        public string[] areaCodes { get; set; }

        /// <summary>
        ///     Filtering by assigned type
        ///     Enum: AssignedUserPhone, UnassignedUserPhone, UnassignedPhone
        /// </summary>
        public string[] assignedTypes { get; set; }

        /// <summary>
        ///     Page number
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records returned per page.
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// </summary>
        public DevicesSearchOrderBy[] orderBy { get; set; }
    }
}