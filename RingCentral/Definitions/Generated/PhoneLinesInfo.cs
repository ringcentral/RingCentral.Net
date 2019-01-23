namespace RingCentral
{
    public class PhoneLinesInfo : Serializable
    {
        // Type of phone line
        // Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        public string lineType;
        // Phone number information
        public PhoneNumberInfoIntId phoneInfo;
    }
}