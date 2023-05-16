namespace RingCentral
{
    public class BulkManageLicensesResponse
    {
        /// <summary>
        /// </summary>
        public LicenseAssignmentResponseEntry[] assignedLicenses { get; set; }

        /// <summary>
        /// </summary>
        public LicenseAssignmentResponseEntry[] unassignedLicenses { get; set; }
    }
}