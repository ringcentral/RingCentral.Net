namespace RingCentral
{
    public class ListAnsweringRulesParameters
    {
        /// <summary>
        /// Default: Simple
        /// Enum: Detailed, Simple
        /// </summary>
        public string view;

        /// <summary>
        /// If true, then only active call handling rules are returned
        /// </summary>
        public bool? enabledOnly;

        /// <summary>
        /// Default: 1
        /// </summary>
        public string page;

        /// <summary>
        /// Default: 100
        /// </summary>
        public string perPage;
    }
}