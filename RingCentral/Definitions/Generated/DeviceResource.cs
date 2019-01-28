namespace RingCentral
{
    public class DeviceResource
    {
        // Internal identifier of a device
        public string id;

        // Canonical URI of a device
        public string uri;

        // Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
        public string sku;

        // Device type
        // Enum: HardPhone, SoftPhone, OtherPhone, Paging, WebPhone
        public string type;

        // Status of a device
        // Enum: Online, Offline
        public string status;

        // Device name. Mandatory if ordering SoftPhone or OtherPhone . Optional for HardPhone . If not specified for HardPhone, then device model name is used as device name
        public string name;

        // Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        public string serial;

        // PC name for softphone
        public string computerName;

        // HardPhone model information
        public ModelInfo model;

        // This attribute can be omitted for unassigned devices
        public ExtensionResourceIntId extension;

        // Phone lines information
        public PhoneLineResource[] phoneLines;

        // Address for emergency cases. The same emergency address is assigned to all numbers of a single device ,
        public EmergencyServiceAddressResource emergencyServiceAddress;

        // Shipping information, according to which devices (in case of HardPhone ) or e911 stickers (in case of SoftPhone and OtherPhone ) will be delivered to the customer
        public ShippingResource shipping;

        // Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either  model structure, or boxBillingId must be specified for HardPhone
        public long? boxBillingId;

        // Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) = ['Host', 'Guest', 'None']
        // Enum: Host, Guest, None
        public string linePooling;

        // Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        public bool? useAsCommonPhone;
    }
}