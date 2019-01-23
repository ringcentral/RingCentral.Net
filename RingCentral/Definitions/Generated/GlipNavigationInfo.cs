namespace RingCentral
{
    public class GlipNavigationInfo : Serializable
    {
        // Previous page token. To get previous page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens
        public string prevPageToken;

        // Next page token. To get next page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens
        public string nextPageToken;
    }
}