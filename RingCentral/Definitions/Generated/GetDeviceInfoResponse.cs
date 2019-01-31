namespace RingCentral
{
    public class GetDeviceInfoResponse
    {
        // Internal identifier of a device
        public string id;

        // Canonical URI of a device
        public string uri;

        // Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
        public string sku;

        // Device type
        // Enum: SoftPhone, OtherPhone, HardPhone
        public string type;

        // Device name. Mandatory if ordering  SoftPhone  or  OtherPhone . Optional for  HardPhone . If not specified for HardPhone, then device  model  name is used as device  name
        public string name;

        // Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        public string serial;

        // PC name for softphone
        public string computerName;

        // HardPhone model information
        public ModelInfo model;

        // This attribute can be omitted for unassigned devices
        public ExtensionInfoIntId extension;

        // Address for emergency cases. The same emergency address is assigned to all the numbers of one device
        public EmergencyAddressInfo emergencyServiceAddress;

        // Phone lines information
        public PhoneLinesInfo[] phoneLines;

        // Shipping information, according to which devices (in case of  HardPhone ) or e911 stickers (in case of  SoftPhone  and  OtherPhone ) will be delivered to the customer
        public ShippingInfo shipping;

        // Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. EitherT? model  structure, or  boxBillingId  must be specified forT?HardPhone
        public long? boxBillingId;

        // Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        public bool? useAsCommonPhone;

        // Network location status. 'True' if the device is located in the configured corporate network (On-Net); 'False' for Off-Net location. Parameter is not returned if `EmergencyAddressAutoUpdate` feature is not enabled for the account/user, or if device network location is not determined
        public bool? inCompanyNet;

        // Site data
        public SiteInfo site;
    }
}