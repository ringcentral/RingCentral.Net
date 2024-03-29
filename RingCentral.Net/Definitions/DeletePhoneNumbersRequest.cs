namespace RingCentral
{
    public class DeletePhoneNumbersRequest
    {
        /// <summary>
        ///     List of phone numbers or phone IDs to be deleted
        ///     Required
        /// </summary>
        public DeletePhoneNumbersRequestItem[] records { get; set; }
    }
}