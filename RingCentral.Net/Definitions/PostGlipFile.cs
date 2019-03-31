namespace RingCentral
{
    public class PostGlipFile
    {
        /// <summary>
        /// Internal identifier of a file
        /// Required
        /// </summary>
        public string id;

        /// <summary>
        /// Link to binary content
        /// Required
        /// </summary>
        public string contentUri;

        /// <summary>
        /// Name of a file
        /// </summary>
        public string name;
    }
}