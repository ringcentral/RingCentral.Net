namespace RingCentral
{
    public class IVRMenuListInfo
    {
        /// <summary>
        ///     Internal identifier of an IVR Menu extension
        ///     Example: 7258440006
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to an IVR Menu extension resource
        ///     Format: uri
        ///     Example: https://api-example.rincentral.com/restapi/v1.0/account/5936989006/ivr-menus/7258440006
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     First name of an IVR Menu user
        ///     Example: IVR Menu 1001
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Number of an IVR Menu extension
        ///     Example: 1001
        /// </summary>
        public string extensionNumber { get; set; }
    }
}