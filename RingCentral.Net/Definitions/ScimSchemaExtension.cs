namespace RingCentral
{
    public class ScimSchemaExtension
    {
        /// <summary>
        ///     Required
        ///     Enum: urn:ietf:params:scim:schemas:extension:enterprise:2.0:User
        /// </summary>
        public string schema { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public bool? required { get; set; }
    }
}