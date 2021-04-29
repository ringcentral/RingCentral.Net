namespace RingCentral
{
    public class ParsePhoneNumberRequest
    {
        /// <summary>
        ///     Phone numbers passed in a string. The maximum value of phone numbers is limited to 64. The maximum number of symbols in each phone number in a string is 64
        /// </summary>
        public string[] originalStrings { get; set; }
    }
}