namespace RingCentral
{
    public class PatchOperation
    {
        /// <summary>
        /// Required
        /// Enum: add, replace, remove
        /// </summary>
        public string op { get; set; }

        /// <summary>
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// corresponding 'value' of that field specified by 'path'
        /// </summary>
        public string value { get; set; }
    }
}