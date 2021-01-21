namespace RingCentral
{
    public class CompanyAnsweringRuleCalledNumberInfoRequest
    {
        /// <summary>
        /// Internal identifier of an account phone number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Phone number of a callee
        /// </summary>
        public string phoneNumber { get; set; }
    }
}