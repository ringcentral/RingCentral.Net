namespace RingCentral
{
    public class GlipCompany
    {
        /// <summary>
        ///     Internal identifier of a Glip company (RC account)
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a company
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Domain name of a company
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        ///     Datetime of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Required
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime of last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Required
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}