namespace RingCentral
{
    public class DeviceResource
    {
        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a device
        /// </summary>
        public string uri;

        /// <summary>
        /// Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
        /// </summary>
        public string sku;

        /// <summary>
        /// Device type
        /// Default: HardPhone
        /// Enum: BLA, HardPhone, SoftPhone, OtherPhone, Paging, WebPhone
        /// </summary>
        public string type;

        /// <summary>
        /// Status of a device
        /// Enum: Online, Offline
        /// </summary>
        public string status;

        /// <summary>
        /// Device name. Mandatory if ordering SoftPhone or OtherPhone . Optional for HardPhone . If not specified for HardPhone, then device model name is used as device name
        /// </summary>
        public string name;

        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        /// </summary>
        public string serial;

        /// <summary>
        /// PC name for softphone
        /// </summary>
        public string computerName;

        /// <summary>
        /// HardPhone model information
        /// </summary>
        public ModelInfo model;

        /// <summary>
        /// This attribute can be omitted for unassigned devices
        /// </summary>
        public ExtensionResourceIntId extension;

        /// <summary>
        /// Phone lines information
        /// </summary>
        public PhoneLineResource[] phoneLines;

        /// <summary>
        /// Address for emergency cases. The same emergency address is assigned to all numbers of a single device
        /// </summary>
        public EmergencyServiceAddressResource emergencyServiceAddress;

        /// <summary>
        /// Shipping information, according to which devices (in case of HardPhone) or e911 stickers (in case of SoftPhone and OtherPhone) will be delivered to the customer
        /// </summary>
        public ShippingResource shipping;

        /// <summary>
        /// Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either  model structure, or boxBillingId must be specified for HardPhone
        /// </summary>
        public long? boxBillingId;

        /// <summary>
        /// Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) = ['Host', 'Guest', 'None']
        /// Enum: Host, Guest, None
        /// </summary>
        public string linePooling;

        /// <summary>
        /// Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        /// </summary>
        public bool? useAsCommonPhone;

        /// <summary>
        /// Network location status. 'True' if device is located in the configured corporate network, in this case `bssid` or public/private IP addresses (`hostIp`) must be found in the corporate maps. If `bssid` is not found in the Wireless Access Points map, then the search is performed by public/private IP addresses in the IP Networks map. 'False' if network parameters are not found in corporate maps (`bssid` and public/private IP addresses for wi-fi or for Ethernet connection)
        /// </summary>
        public bool? inCompanyNet;

        /// <summary>
        /// Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z
        /// </summary>
        public string lastLocationReportTime;
    }
}