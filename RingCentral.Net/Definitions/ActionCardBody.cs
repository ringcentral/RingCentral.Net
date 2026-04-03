namespace RingCentral
{
    public class ActionCardBody
    {
        /// <summary>
        ///     Enum: Input.Text
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     If set to `true`, allows multiple lines of input
        /// </summary>
        public bool? isMultiline { get; set; }

        /// <summary>
        ///     Description of the input desired. Displayed when no text has been input
        /// </summary>
        public string placeholder { get; set; }
    }
}