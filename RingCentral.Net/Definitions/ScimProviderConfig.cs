namespace RingCentral
{
    public class ScimProviderConfig
    {
        /// <summary>
        /// </summary>
        public ScimAuthenticationScheme[] authenticationSchemes { get; set; }

        /// <summary>
        /// </summary>
        public ScimBulkSupported bulk { get; set; }

        /// <summary>
        /// </summary>
        public ScimSupported changePassword { get; set; }

        /// <summary>
        /// </summary>
        public ScimSupported etag { get; set; }

        /// <summary>
        /// </summary>
        public ScimFilterSupported filter { get; set; }

        /// <summary>
        /// </summary>
        public ScimSupported patch { get; set; }

        /// <summary>
        ///     Enum: urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        /// </summary>
        public ScimSupported sort { get; set; }

        /// <summary>
        /// </summary>
        public ScimSupported xmlDataFormat { get; set; }
    }
}