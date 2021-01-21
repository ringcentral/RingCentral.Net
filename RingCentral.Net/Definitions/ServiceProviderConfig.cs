namespace RingCentral
{
    public class ServiceProviderConfig
    {
        /// <summary>
        /// </summary>
        public AuthenticationScheme[] authenticationSchemes { get; set; }

        /// <summary>
        /// </summary>
        public BulkSupported bulk { get; set; }

        /// <summary>
        /// </summary>
        public Supported changePassword { get; set; }

        /// <summary>
        /// </summary>
        public Supported etag { get; set; }

        /// <summary>
        /// </summary>
        public FilterSupported filter { get; set; }

        /// <summary>
        /// </summary>
        public Supported patch { get; set; }

        /// <summary>
        /// Enum: urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        /// </summary>
        public Supported sort { get; set; }

        /// <summary>
        /// </summary>
        public Supported xmlDataFormat { get; set; }
    }
}