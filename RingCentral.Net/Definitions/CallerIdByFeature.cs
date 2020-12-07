namespace RingCentral
{
    // Caller ID settings by feature
    public class CallerIdByFeature
    {
        /// <summary>
        /// Enum: RingOut, RingMe, CallFlip, FaxNumber, AdditionalSoftphone, Alternate, CommonPhone, MobileApp, Delegated
        /// </summary>
        public string feature;

        /// <summary>
        /// </summary>
        public CallerIdByFeatureInfo callerId;
    }
}