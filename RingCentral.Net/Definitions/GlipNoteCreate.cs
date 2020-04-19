namespace RingCentral
{
    public class GlipNoteCreate
    {
        /// <summary>
        /// Title of a note. Max allowed legth is 250 characters
        /// Required
        /// </summary>
        public string title;

        /// <summary>
        /// Contents of a note; HTML-markuped text. Max allowed length is 1048576 characters (1 Mb).
        /// </summary>
        public string body;
    }
}