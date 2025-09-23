namespace RingCentral
{
    /// <summary>
    ///     This parameter is not supported for all User type extensions if the new call handling service
    ///     is activated on account
    /// </summary>
    public class AnsweringRuleQueryRequest
    {
        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }
    }
}