namespace RingCentral
{
    // Site Fax/SMS recipient (operator) reference. Multi-level IVR should be enabled
    public class OperatorInfo
    {
        /// <summary>
        /// Internal identifier of an operator
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link to an operator resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Extension number (pin)
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// Operator extension user full name
        /// </summary>
        public string name { get; set; }
    }
}