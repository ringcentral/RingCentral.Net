namespace RingCentral
{
    public class DeviceResource
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public DeviceResourceAccount account { get; set; }

        /// <summary>
        /// </summary>
        public string phoneLineId { get; set; }

        /// <summary>
        ///     Enum: InProgress, PendingReplacement, Delivered
        /// </summary>
        public string orderStatus { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public DeviceResourceSite site { get; set; }

        /// <summary>
        /// </summary>
        public DeviceResourceExtension extension { get; set; }

        /// <summary>
        /// </summary>
        public DeviceResourcePhoneNumber phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string serial { get; set; }

        /// <summary>
        ///     Enum: AssignedUserPhone, UnassignedUserPhone, UnassignedPhone
        /// </summary>
        public string assignedType { get; set; }
    }
}