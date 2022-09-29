namespace RingCentral
{
    public class IVRMenuList
    {
        /// <summary>
        ///     Link to an IVR Menu list
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of ivr menus
        /// </summary>
        public IVRMenuInfo[] records { get; set; }
    }
}