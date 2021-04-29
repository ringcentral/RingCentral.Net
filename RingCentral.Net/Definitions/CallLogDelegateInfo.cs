namespace RingCentral
{
    // Information on a delegate extension that actually implemented a call action. For Secretary call log the field is returned if the current extension implemented a call. For Boss call log the field contains information on a Secretary extension which actually implemented a call on behalf of the current extension
    public class CallLogDelegateInfo
    {
        /// <summary>
        ///     Internal identifier of a Secretary extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Custom name of a Secretary extension
        /// </summary>
        public string name { get; set; }
    }
}