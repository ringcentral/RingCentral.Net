namespace RingCentral
{
    public class SiteBasicInfo
    {
        /// <summary>
        ///     Site extension identifier or "main-site" for the main site
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Site name
        ///     Required
        /// </summary>
        public string name { get; set; }
    }
}