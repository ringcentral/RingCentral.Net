namespace RingCentral
{
    /// <summary>
    ///     Request to assign/unassign licenses
    /// </summary>
    public class BulkManageLicensesRequest
    {
        /// <summary>
        /// </summary>
        public LicenseAssignmentEntry[] assignedLicenses { get; set; }

        /// <summary>
        /// </summary>
        public LicenseAssignmentEntry[] unassignedLicenses { get; set; }
    }
}