namespace RingCentral
{
    public class DevicesPaginationResource
    {
        /// <summary>
        /// </summary>
        public DeviceResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public PagingInfo paging { get; set; }
    }
}