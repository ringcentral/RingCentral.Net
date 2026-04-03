namespace RingCentral
{
    public class CreateSipRegistrationRequest
    {
        /// <summary>
        /// </summary>
        public DeviceInfoRequest device { get; set; }

        /// <summary>
        ///     SIP settings for device
        /// </summary>
        public SIPInfoRequest[] sipInfo { get; set; }

        /// <summary>
        ///     Supported for Softphone clients only. If 'SoftphoneLineReassignment' feature is enabled
        ///     the reassignment process can be initialized, however if there is no DL for the given user's device
        ///     then SPR-131 error code will be returned.
        ///     Default: None
        ///     Enum: None, Initialize, Reassign
        /// </summary>
        public string softPhoneLineReassignment { get; set; }
    }
}