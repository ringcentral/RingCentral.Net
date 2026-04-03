namespace RingCentral
{
    /// <summary>
    /// Phone Number Parser service's Parse Phone Numbers API successful response schema.
    /// </summary>
    public class ParsePhoneNumberResponseV2
    {
        /// <summary>
        /// </summary>
        public NumberParserContext context { get; set; }

        /// <summary>
        /// </summary>
        public ParsePhoneNumberResponseV2Results[] results { get; set; }
    }
}