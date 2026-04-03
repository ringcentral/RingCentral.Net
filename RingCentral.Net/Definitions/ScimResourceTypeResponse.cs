namespace RingCentral
{
    public class ScimResourceTypeResponse
    {
        /// <summary>
        ///     Unique resource type ID, same value as the "name" attribute
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Resource type name
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     The resource type's HTTP-addressable endpoint
        ///     Required
        /// </summary>
        public string endpoint { get; set; }

        /// <summary>
        ///     Description of the resource type
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: urn:ietf:params:scim:schemas:core:2.0:User
        /// </summary>
        public string schema { get; set; }

        /// <summary>
        /// </summary>
        public ScimSchemaExtension[] schemaExtensions { get; set; }

        /// <summary>
        /// </summary>
        public ScimMeta meta { get; set; }
    }
}