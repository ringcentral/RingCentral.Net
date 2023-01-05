namespace RingCentral
{
    public class ScimErrorResponse
    {
        /// <summary>
        ///     Detailed error message
        /// </summary>
        public string detail { get; set; }

        /// <summary>
        ///     Enum: urn:ietf:params:scim:api:messages:2.0:Error
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        ///     Bad request type when status code is 400
        ///     Enum: uniqueness, tooMany, mutability, sensitive, invalidSyntax, invalidFilter, invalidPath, invalidValue,
        ///     invalidVers, noTarget
        /// </summary>
        public string scimType { get; set; }

        /// <summary>
        ///     Same as HTTP status code, e.g. 400, 401, etc.
        /// </summary>
        public string status { get; set; }
    }
}