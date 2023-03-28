namespace RingCentral
{
    public class FaxCoverPageInfo
    {
        /// <summary>
        ///     Internal identifier of a fax cover page. The supported value
        ///     range is 0-13 (for language setting en-US) and 0, 15-28
        ///     (for all other languages)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a fax cover page pattern
        /// </summary>
        public string name { get; set; }
    }
}