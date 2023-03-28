namespace RingCentral
{
    /// <summary>
    ///     Top IVR Menu extension. Mandatory for MultiLevel mode
    /// </summary>
    public class SiteIVRTopMenu
    {
        /// <summary>
        ///     Internal identifier of an IVR menu extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to an IVR menu extension resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Full name of an IVR menu extension user
        /// </summary>
        public string name { get; set; }
    }
}