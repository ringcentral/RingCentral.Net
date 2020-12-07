namespace RingCentral
{
    // Site Fax/SMS recipient (operator) reference. Multi-level IVR should be enabled
    public class OperatorInfo
    {
        /// <summary>
        /// Internal identifier of an operator
        /// </summary>
        public string id;

        /// <summary>
        /// Link to an operator resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Extension number (pin)
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Operator extension user full name
        /// </summary>
        public string name;
    }
}