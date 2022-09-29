namespace RingCentral
{
    /// <summary>
    ///     Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral
    ///     product terminology
    /// </summary>
    public class DepartmentBulkAssignResource
    {
        /// <summary>
        /// </summary>
        public BulkAssignItem[] items { get; set; }
    }
}