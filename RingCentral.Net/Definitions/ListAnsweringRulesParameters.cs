namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAnsweringRules
    /// </summary>
    public class ListAnsweringRulesParameters
    {
        /// <summary>
        ///     Filters custom call handling rules of the extension
        ///     Enum: Custom
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Default: Simple
        ///     Enum: Detailed, Simple
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     If true, then only active call handling rules are returned
        /// </summary>
        public bool? enabledOnly { get; set; }
    }
}