namespace RingCentral
{
    public class ParsePhoneNumberRequest
    {
        /// <summary>
        ///     The list of phone numbers passed as an array of strings (not more than 64 items). The maximum size of each string
        ///     is 64 characters
        /// </summary>
        public string[] originalStrings { get; set; }
    }
}