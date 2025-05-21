namespace RingCentral
{
    public class CommDeviceResource
    {
        /// <summary>
        ///     Internal identifier of a device
        ///     Required
        ///     Example: 5423543
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device name
        ///     Example: HP2
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}