namespace RingCentral
{
    public class ListAnsweringRulesParameters
    {
        /// <summary>
        /// Default: Simple
        /// Enum: Detailed, Simple
        /// </summary>
        public string view { get; set; }

        /// <summary>
        /// If true, then only active call handling rules are returned
        /// </summary>
        public bool? enabledOnly { get; set; }

        /// <summary>
        /// Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// Default: 100
        /// </summary>
        public string perPage { get; set; }
    }
}