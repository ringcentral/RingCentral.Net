namespace RingCentral
{
    public class ScimPatchOperation
    {
        /// <summary>
        ///     Required
        ///     Enum: add, replace, remove
        /// </summary>
        public string op { get; set; }

        /// <summary>
        /// </summary>
        public string path { get; set; }

        /// <summary>
        ///     Corresponding 'value' of that field specified by 'path'
        /// </summary>
        public string value { get; set; }
    }
}