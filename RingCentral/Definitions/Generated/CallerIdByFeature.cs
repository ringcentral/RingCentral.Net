namespace RingCentral
{
    public class CallerIdByFeature : Serializable
    {
        // Enum: RingOut, RingMe, CallFlip, FaxNumber, AdditionalSoftphone, Alternate, CommonPhone, MobileApp, Delegated
        public string feature;
        public CallerIdByFeatureInfo callerId;
    }
}