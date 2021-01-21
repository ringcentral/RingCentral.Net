namespace RingCentral
{
    public class ProfileImageResource
    {
        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string etag { get; set; }

        /// <summary>
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        /// </summary>
        public string lastModified { get; set; }

        /// <summary>
        /// </summary>
        public ScaledProfileImageResource[] scales { get; set; }
    }
}