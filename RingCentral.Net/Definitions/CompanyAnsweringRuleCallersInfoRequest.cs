namespace RingCentral
{
    public class CompanyAnsweringRuleCallersInfoRequest
    {
        /// <summary>
        /// Phone number of a caller
        /// </summary>
        public string callerId { get; set; }

        /// <summary>
        /// Displayed name for a caller ID
        /// </summary>
        public string name { get; set; }
    }
}