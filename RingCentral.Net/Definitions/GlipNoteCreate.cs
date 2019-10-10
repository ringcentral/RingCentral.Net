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
        /// Contents of a note; HTML-markuped text. Max allowed length is 102400 characters (100 Kb).
        /// </summary>
        public string body;
    }
}