namespace RingCentral
{
    public class ScimAuthenticationScheme
    {
        /// <summary>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string documentationUri { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string specUri { get; set; }

        /// <summary>
        /// </summary>
        public bool? primary { get; set; }
    }
}