namespace RingCentral
{
    // Extension profile image information. Not returned if profile images are absent for an extension
    public class CompanyDirectoryProfileImageInfo
    {
        /// <summary>
        /// Link to a profile image resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of an image
        /// </summary>
        public string etag;
    }
}