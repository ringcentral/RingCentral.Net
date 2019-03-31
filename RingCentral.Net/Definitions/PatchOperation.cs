namespace RingCentral
{
    public class PatchOperation
    {
        /// <summary>
        /// Required
        /// Enum: add, replace, remove
        /// </summary>
        public string op;

        /// <summary>
        /// </summary>
        public string path;

        /// <summary>
        /// corresponding 'value' of that field specified by 'path'
        /// </summary>
        public string value;
    }
}