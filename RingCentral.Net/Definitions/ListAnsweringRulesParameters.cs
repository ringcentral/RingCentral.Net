namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAnsweringRules
    /// </summary>
    public class ListAnsweringRulesParameters
    {
        /// <summary>
        ///     Type of an answering rule. Multiple values are supported
        ///     Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     Default: Simple
        ///     Enum: Detailed, Simple
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     If true, then only active call handling rules are returned
        /// </summary>
        public bool? enabledOnly { get; set; }

        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}