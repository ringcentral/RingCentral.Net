namespace RingCentral
{
    /// <summary>
    ///     Attachment is a file to be uploaded
    /// </summary>
    public class Attachment
    {
        /// <summary>
        ///     Filename with extension
        ///     Example: example.png
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        ///     Binary content of the file
        ///     Required
        /// </summary>
        public byte[] content { get; set; }

        /// <summary>
        ///     Content type of the file, such as "image/png"
        /// </summary>
        public string contentType { get; set; }
    }
}