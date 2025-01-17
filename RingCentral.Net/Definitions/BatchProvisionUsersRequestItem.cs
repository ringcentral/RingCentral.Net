namespace RingCentral
{
    /// <summary>
    ///     Describes request for user extension provisioning
    /// </summary>
    public class BatchProvisionUsersRequestItem
    {
        /// <summary>
        ///     Short number of an extension.
        ///     Actual max length depends on system length limit for extension.
        ///     Example: 205
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Extension status. Only "Enabled" can be specified
        ///     Required
        ///     Default: Enabled
        ///     Enum: Enabled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Personal contact information
        ///     Required
        /// </summary>
        public BatchProvisionUsersRequestItemContact contact { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersRequestItemCostCenter costCenter { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersRequestItemRoles[] roles { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersRequestItemDevices[] devices { get; set; }
    }
}