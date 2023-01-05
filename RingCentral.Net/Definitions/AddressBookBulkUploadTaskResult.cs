namespace RingCentral
{
    public class AddressBookBulkUploadTaskResult
    {
        /// <summary>
        /// </summary>
        public AddressBookBulkUploadResource[] affectedItems { get; set; }

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors { get; set; }
    }
}