namespace RingCentral
{
    // Result record on adding multiple contacts to an extension. Returned for completed tasks
    public class AddressBookBulkUploadTaskResult
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkContactResource contact { get; set; }

        /// <summary>
        ///     Adding contact status
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors { get; set; }
    }
}