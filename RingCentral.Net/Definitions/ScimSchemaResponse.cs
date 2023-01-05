namespace RingCentral
{
    public class ScimSchemaResponse
    {
        /// <summary>
        ///     The unique URI of the schema
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     The name of the schema
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     The description of the schema
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public ScimSchemaAttribute[] attributes { get; set; }

        /// <summary>
        /// </summary>
        public ScimMeta meta { get; set; }
    }
}