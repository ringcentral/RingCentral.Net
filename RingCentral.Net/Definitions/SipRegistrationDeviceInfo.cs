namespace RingCentral
{
    public class SipRegistrationDeviceInfo
    {
        /// <summary>
        ///     Canonical URI of the resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a device
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device type
        ///     Enum: HardPhone, SoftPhone, OtherPhone, Paging, WebPhone, Room
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Device identification number (stock keeping unit) in the format
        ///     TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all
        ///     other devices including softphone); ID - device model ID; AT -addon type
        ///     ID; AC - addon count (if any). For example 'HP-56-2-2'
        /// </summary>
        public string sku { get; set; }

        /// <summary>
        ///     Enum: Online, Offline
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Device name. Mandatory if ordering  SoftPhone or OtherPhone.
        ///     Optional for  HardPhone. If not specified for HardPhone, then device  model  name
        ///     is used as device  name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Serial number for HardPhone (is returned only when the phone
        ///     is shipped and provisioned); endpoint_id for Softphone and mobile applications
        /// </summary>
        public string serial { get; set; }

        /// <summary>
        ///     Computer name for Softphone devices
        /// </summary>
        public string computerName { get; set; }

        /// <summary>
        /// </summary>
        public DeviceModelInfo model { get; set; }

        /// <summary>
        /// </summary>
        public DeviceExtensionInfo extension { get; set; }

        /// <summary>
        /// </summary>
        public DeviceEmergencyServiceAddressResource emergencyServiceAddress { get; set; }

        /// <summary>
        /// </summary>
        public SipRegistrationDeviceEmergencyInfo emergency { get; set; }

        /// <summary>
        /// </summary>
        public ShippingInfo shipping { get; set; }

        /// <summary>
        ///     Phone lines information
        /// </summary>
        public DevicePhoneLinesInfo[] phoneLines { get; set; }

        /// <summary>
        ///     Box billing identifier of a device. Applicable only for HardPhones.
        ///     It is an alternative way to identify the device to be ordered. Either
        ///     model  structure, or  boxBillingId  must be specified forT?HardPhone
        ///     Format: int64
        /// </summary>
        public long? boxBillingId { get; set; }

        /// <summary>
        ///     Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a
        ///     common phone.
        /// </summary>
        public bool? useAsCommonPhone { get; set; }

        /// <summary>
        ///     Pooling type of a deviceHost - device with standalone paid
        ///     phone line which can be linked to Glip/Softphone instanceGuest - device
        ///     with a linked phone lineNone - device without a phone line or with specific
        ///     line (free, BLA, etc.) = ['Host', 'Guest', 'None']
        ///     Enum: Host, Guest, None
        /// </summary>
        public string linePooling { get; set; }

        /// <summary>
        ///     Network location status. 'True' if the device is located in
        ///     the configured corporate network (On-Net); 'False' for Off-Net location.
        ///     Parameter is not returned if `EmergencyAddressAutoUpdate` feature is not
        ///     enabled for the account/user, or if device network location is not determined
        /// </summary>
        public bool? inCompanyNet { get; set; }

        /// <summary>
        /// </summary>
        public DeviceSiteInfo site { get; set; }

        /// <summary>
        ///     Timestamp of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, for example *2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastLocationReportTime { get; set; }
    }
}