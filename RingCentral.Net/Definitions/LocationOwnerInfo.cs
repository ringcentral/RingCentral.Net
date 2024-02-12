namespace RingCentral
{
    public class LocationOwnerInfo
    {
        /// <summary>
        ///     Internal identifier of a user - private location owner
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension number of a location number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of a location owner
        /// </summary>
        public string name { get; set; }
    }
}