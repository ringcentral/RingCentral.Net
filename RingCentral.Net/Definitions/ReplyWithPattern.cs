namespace RingCentral
{
    public class ReplyWithPattern
    {
        /// <summary>
        /// Predefined reply pattern name.
        /// Enum: WillCallYouBack, CallMeBack, OnMyWay, OnTheOtherLine, WillCallYouBackLater, CallMeBackLater, InAMeeting, OnTheOtherLineNoCall
        /// </summary>
        public string pattern;

        /// <summary>
        /// Number of time units. Applicable only to WillCallYouBack, CallMeBack patterns.
        /// </summary>
        public long? time;

        /// <summary>
        /// Time unit name.
        /// Enum: Minute, Hour, Day
        /// </summary>
        public string timeUnit;
    }
}