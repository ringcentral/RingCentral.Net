namespace RingCentral
{
    public class FaxCoverPageInfo
    {
        /* Internal identifier of a fax cover page. The possible value range is 0-13 (for language setting en-US) and 0, 15-28 (for all other languages) */
        public long? id;

        /* Name of a fax cover page pattern */
        public string name;
    }
}