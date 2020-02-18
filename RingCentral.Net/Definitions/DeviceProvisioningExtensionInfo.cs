namespace RingCentral
{
    public class DeviceProvisioningExtensionInfo
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        public string uri;

        /// <summary>
        /// Number of department extension
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        public string partnerId;
    }
}