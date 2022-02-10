namespace RingCentral
{
    /// <summary>
    ///     Extension profile image information. Not returned if profile images are absent for an extension
    /// </summary>
    public class CompanyDirectoryProfileImageInfo
    {
        /// <summary>
        ///     Link to a profile image resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an image
        /// </summary>
        public string etag { get; set; }
    }
}