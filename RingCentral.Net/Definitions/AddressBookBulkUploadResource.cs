namespace RingCentral
{
    public class AddressBookBulkUploadResource
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Required
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     List of contacts to be added to extension address book
        ///     Required
        /// </summary>
        public AddressBookBulkContactResource[] contacts { get; set; }
    }
}