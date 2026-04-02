namespace RingCentral
  {
    /// <summary>
/// Absent if the request's parameter `resultContent.includeNumberDetails` value is set to `false`.
/// </summary>
      public class NumberDetails
      {
          /// <summary>
        ///     Absent if the request's parameter `context.siteCode` value is set to `null`.
        ///     Example: 10
        /// </summary>
        public string siteCode { get; set; }

        /// <summary>
        ///     Absent if the request's parameter `context.siteCode` value is set to `null`.
        ///     Example: 303
        /// </summary>
        public string shortExtensionNumber { get; set; }

        /// <summary>
        ///     Absent for the `results.category` response's attribute values:
            ///     `Unknown`, `ServiceCode`, `SpecialService`, `Regular`, `TollFree` and `ShortCode`.
        ///     Example: 10303
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Absent for the `results.category` response's attribute values:
            ///     `Unknown`, `ServiceCode`, `Extension`, `Regular`, `TollFree`, `ShortCode` and `Ambiguous`.
        /// </summary>
        public NumberDetailsSpecialService specialService { get; set; }

        /// <summary>
        /// </summary>
        public CountryContext country { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a national destination code.
        /// </summary>
        public string nationalDestinationCode { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain an area code.
        ///     Example: 650
        /// </summary>
        public string areaCode { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a regional destination code.
        /// </summary>
        public string regionalDestinationCode { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain an allocation block code.
        /// </summary>
        public string allocationBlockCode { get; set; }

        /// <summary>
        ///     Absent for the `results.category` response's attribute values: `Unknown`, `ServiceCode` and `Extension`.
        ///     Example: 5558275
        /// </summary>
        public string subscriberNumber { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a sub-address.
        ///     Example: 1019
        /// </summary>
        public string subAddress { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a DTMF postfix.
        ///     Example: ,,,1,3,1,
        /// </summary>
        public string dtmfPostfix { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a SIP postfix.
        ///     Example: @sip.ringcentral.com
        /// </summary>
        public string sipPostfix { get; set; }

        /// <summary>
        ///     Absent if the request's parameter `context.maskedPhoneNumbersAllowed` value is set to `false`.
        /// </summary>
        public bool? probablyMasked { get; set; }

        /// <summary>
        ///     Absent for the `results.category` response's attribute values:
            ///     `Unknown`, `SpecialService`, `Extension`, `TollFree`, `ShortCode` and `Ambiguous`.
        ///     Example: Valid
        ///     Enum: Valid, Possible, Invalid
        /// </summary>
        public string status { get; set; }
      }
  }