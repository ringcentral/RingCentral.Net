namespace RingCentral
{
    public class PhoneLinesInfo
    {
        /// <summary>
        /// Type of phone line
        /// Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType;

        /// <summary>
        /// Phone number information
        /// </summary>
        public PhoneNumberInfoIntId phoneInfo;
    }
}