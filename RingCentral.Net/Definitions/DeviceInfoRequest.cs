namespace RingCentral
{
    public class DeviceInfoRequest
    {
        /// <summary>
        /// Device unique identifier, retrieved on previous session (if any)
        /// </summary>
        public string id;

        /// <summary>
        /// For iOS devices only Certificate name (used by iOS applications for APNS subscription)
        /// </summary>
        public string appExternalId;

        /// <summary>
        /// For SoftPhone only Computer name
        /// </summary>
        public string computerName;
    }
}