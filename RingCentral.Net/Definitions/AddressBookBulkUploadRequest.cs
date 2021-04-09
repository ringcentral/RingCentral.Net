namespace RingCentral
{
    public class AddressBookBulkUploadRequest
    {
        /// <summary>
        ///     List of extensions which contacts have to be updated
        ///     Required
        /// </summary>
        public AddressBookBulkUploadResource[] records { get; set; }
    }
}