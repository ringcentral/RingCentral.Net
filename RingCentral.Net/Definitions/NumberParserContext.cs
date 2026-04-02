namespace RingCentral
  {
    /// <summary>
/// The manually set parsing context to override the context parameter values taken from the context source.
/// </summary>
      public class NumberParserContext
      {
          /// <summary>
        ///     Internal identifier of the RingCentral brand. Brand context definition.
            ///     
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> `null`
            ///       - `Account` -> brand from the request context header
            ///     - Explicitly set value redefines the value taken from the context source.
            ///     - Explicitly set `null` value disables brand context for parsing.
        ///     Example: 1210
        /// </summary>
        public string brandId { get; set; }

        /// <summary>
        /// </summary>
        public CountryContext country { get; set; }

        /// <summary>
        ///     Default area code of the caller. Provides support for the dial plan feature
            ///     "[Default Area Code](https://support.ringcentral.com/article/dial-plan-default-area-code-ringcentral-mvp.html)".
            ///     
            ///     If the value is not specified or explicitly set to `null`, the feature "Default Area Code" context is disabled for parsing.
        ///     Example: 650
        /// </summary>
        public string defaultAreaCode { get; set; }

        /// <summary>
        ///     Vanity phone numbers are supported in the parsing input. Provides support for the feature
            ///     "[Vanity Numbers dialing](https://support.ringcentral.com/article/Requesting-a-toll-free-vanity-number.html)".
            ///     
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> `false`
            ///       - `Account` -> `true`
            ///     - Explicitly set value redefines the value taken from the context source.
        ///     Example: true
        /// </summary>
        public bool? vanityPhoneNumbersAllowed { get; set; }

        /// <summary>
        ///     The maximum allowed length of extension numbers on the account. Provides support for the dial plan feature
            ///     "[Variable-length Extensions](https://support.ringcentral.com/article/11277-Enterprise-Dial-Plan-Max-Extension-Length.html)".
            ///     
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> _5_
            ///       - `Account` -> the value from the requester's account settings
            ///     - Explicitly set value redefines the value taken from the context source.
            ///     - Explicitly set `null` value disables extension numbers detection.
        ///     Maximum: 9
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? maxExtensionNumberLength { get; set; }

        /// <summary>
        ///     Short codes are supported in the parsing input. Provides support for the feature "Shortcodes dialing".
            ///     
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> `false`
            ///       - `Account` -> the value from the requester's account settings
            ///     - Explicitly set value redefines the value taken from the context source.
        /// </summary>
        public bool? shortCodesAllowed { get; set; }

        /// <summary>
        ///     The site code of caller. Together with parameter `context.shortExtensionNumberLength` provides support for the feature
            ///     "[Site Codes](https://support.ringcentral.com/article/11279-Enterprise-Dial-Plan-Site-Codes.html)".
            ///     
            ///     - If the value is not specified or explicitly set to `null`, the feature "Site Codes" context is disabled for parsing.
        ///     Example: 13
        /// </summary>
        public string siteCode { get; set; }

        /// <summary>
        ///     The allowed length of short extension numbers on the account.
            ///     Together with parameter `context.siteCode` provides support for the feature
            ///     "[Site Codes](https://support.ringcentral.com/article/11279-Enterprise-Dial-Plan-Site-Codes.html)".
            ///     
            ///     - The value is ignored and treated as `null` if parameter `context.siteCode` is not specified or explicitly set to `null`.
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> _3_
            ///       - `Account` -> the value from the requester's account settings
            ///     - Explicitly set value redefines the value taken from the context source.
        ///     Maximum: 8
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 4
        /// </summary>
        public long? shortExtensionNumberLength { get; set; }

        /// <summary>
        ///     Digit of outbound call prefix on the account. Provides support for the dial plan feature
            ///     "[Outbound Call Prefix](https://support.ringcentral.com/article/11278-Enterprise-Dial-Plan-Outbound-Call-Prefix.html)".
            ///     
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> `null`
            ///       - `Account` -> the value from the requester's account settings
            ///     - Explicitly set value redefines the value taken from the context source.
            ///     - Explicitly set `null` value disables outbound call prefix detection.
        ///     Example: 9
        /// </summary>
        public string outboundCallPrefix { get; set; }

        /// <summary>
        ///     Masked phone numbers are supported in the the parsing input.
            ///     Provides support for the feature "[Masked Numbers](https://support.ringcentral.com/article/Number-Masking-French-Numbers.html)".
            ///     
            ///     - If the value is not specified or explicitly set to `false`, the feature "Masked Numbers" context is disabled for parsing.
        /// </summary>
        public bool? maskedPhoneNumbersAllowed { get; set; }

        /// <summary>
        ///     A character used for masking phone numbers.
            ///     
            ///     Absent if the request's parameter `context.maskedPhoneNumbersAllowed` value is set to `false`.
        ///     Example: X
        /// </summary>
        public string maskSymbol { get; set; }

        /// <summary>
        ///     The number of last digits of the phone number which are masked.
            ///     
            ///     Absent if the request's parameter `context.maskedPhoneNumbersAllowed` value is set to `false`.
        ///     Format: int32
        ///     Example: 4
        /// </summary>
        public long? maskLength { get; set; }

        /// <summary>
        ///     Defines the logic of conflicts resolving when it's impossible to detect whether the inputted string
            ///     corresponds to an extension number or a phone number. Provides support for the feature "Smart Dial Plan Routing".
            ///     
            ///     **Possible values**:
            ///     
            ///     - `Default` - the ambiguous number will always be classified as an extension number;
            ///     - `Client` - the ambiguous number will get `Ambiguous` category and the final decision whether the number is an extension number or a phone number should be made by the requester.
            ///     - If the value is not specified, it's taken from the context source:
            ///       - `Default` -> _Default_
            ///       - `Client` -> the value from the requester's account settings
            ///     - Explicitly set value redefines the value taken from the context source.
        ///     Example: Client
        ///     Default: Default
        ///     Enum: Default, Client
        /// </summary>
        public string conflictHandling { get; set; }
      }
  }