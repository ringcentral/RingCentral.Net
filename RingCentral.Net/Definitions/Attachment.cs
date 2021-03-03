namespace RingCentral
{
    public class Attachment
    {
        /// <summary>
        /// File name with extension, such as "example.png"
        /// </summary>
        public string fileName;

        /// <summary>
        /// Binary content of the file
        /// </summary>
        public byte[] bytes;

        /// <summary>
        /// Content type of the file, such as "image/png"
        /// </summary>
        public string contentType;
    }
}