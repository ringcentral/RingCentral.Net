namespace RingCentral
{
    public class ProfileImageInfo
    {
        /// <summary>
        /// Link to a profile image. If an image is not uploaded for an extension, only uri is returned
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// Identifier of an image
        /// </summary>
        public string etag;

        /// <summary>
        /// The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string lastModified;

        /// <summary>
        /// The type of an image
        /// </summary>
        public string contentType;

        /// <summary>
        /// List of URIs to profile images in different dimensions
        /// </summary>
        public ProfileImageInfoURI[] scales;
    }
}