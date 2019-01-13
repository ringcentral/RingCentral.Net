using Newtonsoft.Json;

namespace RingCentral
{
    public class ExtensionServiceFeatureInfo : Serializable
    {
        // Feature status; shows feature availability for an extension
        public bool? enabled;
        // Feature name
        public string featureName;
        // Reason of limitation for a particular service feature. Returned only if the enabled parameter value is 'False', see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
        public string reason;
    }
}