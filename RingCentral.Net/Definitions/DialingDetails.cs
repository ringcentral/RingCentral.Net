namespace RingCentral
{
    /// <summary>
    /// Absent if the request's parameter `resultContent.includeDialingDetails` value is set to `false`.
    /// </summary>
    public class DialingDetails
    {
        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a service code.
        /// </summary>
        public DialingDetailsServiceCode serviceCode { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain an outbound call prefix.
        ///     Example: 9
        /// </summary>
        public string outboundCallPrefix { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a special prefix.
        /// </summary>
        public DialingDetailsSpecialPrefix specialPrefix { get; set; }
    }
}