namespace RingCentral
{
    public class ServiceProviderConfig
    {
        /// <summary>
        /// </summary>
        public AuthenticationScheme[] authenticationSchemes;

        /// <summary>
        /// </summary>
        public BulkSupported bulk;

        /// <summary>
        /// </summary>
        public Supported changePassword;

        /// <summary>
        /// </summary>
        public Supported etag;

        /// <summary>
        /// </summary>
        public FilterSupported filter;

        /// <summary>
        /// </summary>
        public Supported patch;

        /// <summary>
        /// Enum: urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig
        /// </summary>
        public string[] schemas;

        /// <summary>
        /// </summary>
        public Supported sort;

        /// <summary>
        /// </summary>
        public Supported xmlDataFormat;
    }
}