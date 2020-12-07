namespace RingCentral
{
    public class GetDeviceInfoResponse
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
        /// Enum: BLA, SoftPhone, OtherPhone, HardPhone, WebPhone, Paging
        /// </summary>
        public string type;

        /// <summary>
        /// Device name. Mandatory if ordering  SoftPhone  or  OtherPhone. Optional for  HardPhone. If not specified for HardPhone, then device model name is used as device name
        /// </summary>
        public string name;

        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        /// </summary>
        public string serial;

        /// <summary>
        /// Device status
        /// Enum: Offline, Online
        /// </summary>
        public string status;

        /// <summary>
        /// PC name for softphone
        /// </summary>
        public string computerName;

        /// <summary>
        /// </summary>
        public ModelInfo model;

        /// <summary>
        /// </summary>
        public ExtensionInfoIntId extension;

        /// <summary>
        /// </summary>
        public DeviceEmergencyInfo emergency;

        /// <summary>
        /// </summary>
        public EmergencyServiceAddressResource emergencyServiceAddress;

        /// <summary>
        /// Phone lines information
        /// </summary>
        public PhoneLinesInfo[] phoneLines;

        /// <summary>
        /// </summary>
        public ShippingInfo shipping;

        /// <summary>
        /// Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. EitherT? model  structure, or  boxBillingId  must be specified forT?HardPhone
        /// </summary>
        public long? boxBillingId;

        /// <summary>
        /// Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        /// </summary>
        public bool? useAsCommonPhone;

        /// <summary>
        /// Network location status. 'True' if the device is located in the configured corporate network (On-Net); 'False' for Off-Net location. Parameter is not returned if `EmergencyAddressAutoUpdate` feature is not enabled for the account/user, or if device network location is not determined
        /// </summary>
        public bool? inCompanyNet;

        /// <summary>
        /// </summary>
        public DeviceSiteInfo site;

        /// <summary>
        /// Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z
        /// </summary>
        public string lastLocationReportTime;

        /// <summary>
        /// Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) = ['Host', 'Guest', 'None']
        /// Enum: Host, Guest, None
        /// </summary>
        public string linePooling;

        /// <summary>
        /// </summary>
        public BillingStatementInfo billingStatement;
    }
}