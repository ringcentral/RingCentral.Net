namespace RingCentral
{
    public class GetServiceInfoResponse : Serializable
    {
        // Canonical URI of the account Service Info resource
        public string uri;
        // Account Service Plan name
        public string servicePlanName;
        // Service features information, see Service Feature List
        public ServiceFeatureInfo[] serviceFeatures;
        // Limits which are effective for the account
        public AccountLimits limits;
    }
}