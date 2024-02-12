namespace RingCentral
{
    /// <summary>
    ///     Information on profile image
    /// </summary>
    public class ProfileImageInfo
    {
        /// <summary>
        ///     Link to a profile image. If an image is not uploaded for an
        ///     extension, only `uri` is returned
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Identifier of an image
        /// </summary>
        public string etag { get; set; }

        /// <summary>
        ///     Date/time when an image was last updated, in ISO 8601 format,
        ///     for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModified { get; set; }

        /// <summary>
        ///     The type of image
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     List of URIs to profile images in different dimensions
        /// </summary>
        public ProfileImageInfoURI[] scales { get; set; }
    }
}