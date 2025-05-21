namespace RingCentral
{
    /// <summary>
    ///     File information
    /// </summary>
    public class TMAddFile
    {
        /// <summary>
        ///     Internal identifier of a file
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a binary content
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