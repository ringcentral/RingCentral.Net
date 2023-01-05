namespace RingCentral
{
    public class AddressBookBulkUploadResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AddressBookBulkContactResource[] contacts { get; set; }
    }
}