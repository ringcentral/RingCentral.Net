namespace RingCentral
{
    public class RangesInfo
    {
        /// <summary>
        /// Starting datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601), for example *2018-10-29T14:00:00*, *2018-10-29T14:00:00Z*, *2018-10-29T14:00:00+0100*
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// Ending datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601), for example *2018-10-29T14:00:00*, *2018-10-29T14:00:00Z*, *2018-10-29T14:00:00+0100*
        /// </summary>
        public string to { get; set; }
    }
}