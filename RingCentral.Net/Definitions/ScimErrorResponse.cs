namespace RingCentral
{
    public class ScimErrorResponse
    {
        /* detail error message */
        public string detail;

        public string[] schemas;

        /* bad request type when status code is 400 */
        // Enum: uniqueness, tooMany, mutability, sensitive, invalidSyntax, invalidFilter, invalidPath, invalidValue, invalidVers, noTarget
        public string scimType;

        /* same as HTTP status code, e.g. 400, 401, etc. */
        public string status;
    }
}