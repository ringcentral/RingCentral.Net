namespace RingCentral
  {
    /// <summary>
/// Phone Number Parser service's Parse Phone Numbers API request schema.
/// </summary>
      public class ParsePhoneNumbersRequest
      {
          /// <summary>
        ///     Array of strings containing numbers to be parsed.
            ///     
            ///     Empty strings or `null` values of the array are ignored and excluded from the request.
        ///     Required
        /// </summary>
        public string[] originalStrings { get; set; }

        /// <summary>
        ///     The source of the parsing context.
            ///     
            ///     **Possible values**:
            ///     <br>- `Default` - using default values of parameters for the parsing;
            ///     <br>- `Account` - populating parsing context from requester's account settings.
            ///     |`context.`                  |`Default`|`Account`
            ///     |----------------------------|---------|--------------------------------------------
            ///     |`brandId`                   |`null`   |brand from the request context header
            ///     |`country`                   |`null`   |home country of the requester's account
            ///     |`defaultAreaCode`           |`null`   |`null`
            ///     |`vanityPhoneNumbersAllowed` |`false`  |`true`
            ///     |`maxExtensionNumberLength`  |_5_      |the value from the requester's account settings
            ///     |`shortCodesAllowed`         |`false`  |the value from the requester's account settings
            ///     |`siteCode`                  |`null`   |`null`
            ///     |`shortExtensionNumberLength`|_3_      |the value from the requester's account settings
            ///     |`outboundCallPrefix`        |`null`   |the value from the requester's account settings
            ///     |`maskedPhoneNumbersAllowed` |`false`  |`false`
            ///     |`conflictHandling`          |`Default`|the value from the requester's account settings
        ///     Example: Account
        ///     Default: Default
        ///     Enum: Default, Account
        /// </summary>
        public string contextSource { get; set; }

        /// <summary>
        /// </summary>
        public NumberParserContext context { get; set; }

        /// <summary>
        /// </summary>
        public ResultContent resultContent { get; set; }
      }
  }