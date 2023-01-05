namespace RingCentral
{
    public class TMAddFileRequest
    {
        /// <summary>
        ///     Internal identifier of a file
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to binary content
        ///     Required
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Name of a file
        /// </summary>
        public string name { get; set; }
    }
}