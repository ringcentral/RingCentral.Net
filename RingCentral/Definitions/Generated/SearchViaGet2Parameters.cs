namespace RingCentral
{
    public class SearchViaGet2Parameters
    {
        // only support 'userName' or 'email' filter expressions for now
        public string filter;

        // start index (1-based)
        // Default: 1
        public long? startIndex;

        // page size
        // Default: 100
        public long? count;
    }
}