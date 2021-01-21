namespace RingCentral
{
    public class AutomaticLocationUpdatesPhoneLine
    {
        /// <summary>
        /// Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary, BLF
        /// </summary>
        public string lineType { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesPhoneNumberInfo phoneInfo { get; set; }
    }
}