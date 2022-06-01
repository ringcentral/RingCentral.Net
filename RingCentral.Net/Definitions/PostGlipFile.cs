namespace RingCentral
{
    public class PostGlipFile
    {
        /// <summary>
        ///     Internal identifier of a file
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to binary content
        ///     Required
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Name of a file
        /// </summary>
        public string name { get; set; }
    }
}