namespace RingCentral
{
    public class PagingDeviceInfo
    {
        /// <summary>
        ///     Internal identifier of a paging device
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a paging device resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Name of a paging device
        /// </summary>
        public string name { get; set; }
    }
}