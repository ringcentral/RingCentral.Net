namespace RingCentral
{
    public class AddPhoneNumbersRequest
    {
        /// <summary>
        ///     List of account phone numbers
        ///     Required
        /// </summary>
        public AddPhoneNumberRequestItem[] records { get; set; }
    }
}