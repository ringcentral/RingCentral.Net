namespace RingCentral
{
    public class ScimSchemaAttribute
    {
        /// <summary>
        ///     The name of the attribute
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: string, boolean, decimal, integer, dateTime, reference, complex
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public ScimSchemaAttribute[] subAttributes { get; set; }

        /// <summary>
        ///     A Boolean value indicating the attribute's plurality
        ///     Required
        /// </summary>
        public bool? multiValued { get; set; }

        /// <summary>
        ///     The description of the attribute
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public bool? required { get; set; }

        /// <summary>
        ///     A collection of suggested canonical values
        /// </summary>
        public string[] canonicalValues { get; set; }

        /// <summary>
        /// </summary>
        public bool? caseExact { get; set; }

        /// <summary>
        ///     Indicates the circumstances under which the value of the attribute can be (re)defined
        ///     Required
        ///     Enum: readOnly, readWrite, immutable, writeOnly
        /// </summary>
        public string mutability { get; set; }

        /// <summary>
        ///     Indicates when an attribute and associated values are returned
        ///     Required
        ///     Enum: always, never, default, request
        /// </summary>
        public string returned { get; set; }

        /// <summary>
        ///     Specifies how the service provider enforces uniqueness of attribute values
        ///     Required
        ///     Enum: none, server, global
        /// </summary>
        public string uniqueness { get; set; }

        /// <summary>
        ///     Indicates the SCIM resource types that be referenced
        /// </summary>
        public string[] referenceTypes { get; set; }
    }
}