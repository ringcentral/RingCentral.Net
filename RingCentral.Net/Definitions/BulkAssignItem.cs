namespace RingCentral
{
    public class BulkAssignItem
    {
        /// <summary>
        /// </summary>
        public string departmentId { get; set; }

        /// <summary>
        /// </summary>
        public string[] addedExtensionIds { get; set; }

        /// <summary>
        /// </summary>
        public string[] removedExtensionIds { get; set; }
    }
}