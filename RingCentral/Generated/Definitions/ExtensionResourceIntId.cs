using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionResourceIntId : Serializable
    {
        public string uri;
        public long? id;
        public string partnerId;
        public string extensionNumber;
        public string loginName;
        public ContactInfo contact;
        public Reference[] references;
        public string name;
        public string type;
        public string status;
        public StatusInfo statusInfo;
        public DepartmentResource[] departments;
        public ServiceFeatureValue[] serviceFeatures;
        public RegionalSettingsResource regionalSettings;
        public string setupWizardState;
        public ExtensionPermissionsResource permissions;
        public string password;
        public string ivrPin;
        public ProfileImageResource profileImage;
    }
}