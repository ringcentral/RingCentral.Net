namespace RingCentral
{
    public class Attachment
    {
        // File name with extension, such as "example.png"
        public string fileName;

        // Binary content of the file
        public byte[] bytes;

        // Content tyle of the file, such as "image/png"
        public string contentType;
    }
}