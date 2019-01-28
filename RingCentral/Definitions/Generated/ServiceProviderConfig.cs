namespace RingCentral
{
    public class ServiceProviderConfig
    {
        public AuthenticationScheme[] authenticationSchemes;
        public BulkSupported bulk;
        public Supported changePassword;
        public Supported etag;
        public FilterSupported filter;
        public Supported patch;
        public string[] schemas;
        public Supported sort;
        public Supported xmlDataFormat;
    }
}