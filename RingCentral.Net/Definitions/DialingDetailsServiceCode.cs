namespace RingCentral
{
    public class DialingDetailsServiceCode
    {
        /// <summary>
        ///     Example: *811
        /// </summary>
        public string dialing { get; set; }

        /// <summary>
        ///     Absent if the response's attribute `results.originalString` value doesn't contain a valid RingCentral's service code.
        ///     Example: *8xx
        /// </summary>
        public string pattern { get; set; }
    }
}