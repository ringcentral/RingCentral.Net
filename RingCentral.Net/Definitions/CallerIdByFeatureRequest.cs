namespace RingCentral
{
    // Caller ID settings by feature
    public class CallerIdByFeatureRequest
    {
        /// <summary>
        ///     Enum: RingOut, RingMe, CallFlip, FaxNumber, AdditionalSoftphone, Alternate, CommonPhone, MobileApp, Delegated
        /// </summary>
        public string feature { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdByFeatureInfoRequest callerId { get; set; }
    }
}