namespace RingCentral
{
    public class IVRMenuList
    {
        /// <summary>
        ///     Link to an IVR Menu list
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of ivr menus
        /// </summary>
        public IVRMenuListInfo[] records { get; set; }
    }
}