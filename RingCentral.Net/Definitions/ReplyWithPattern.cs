namespace RingCentral
{
    public class ReplyWithPattern
    {
        /// <summary>
        ///     Predefined reply pattern name.
        ///     Example: OnMyWay
        ///     Enum: WillCallYouBack, CallMeBack, OnMyWay, OnTheOtherLine, WillCallYouBackLater, CallMeBackLater, InAMeeting,
        ///     OnTheOtherLineNoCall
        /// </summary>
        public string pattern { get; set; }

        /// <summary>
        ///     Number of time units. Applicable only to WillCallYouBack, CallMeBack patterns.
        ///     Example: 5
        /// </summary>
        public long? time { get; set; }

        /// <summary>
        ///     Time unit name.
        ///     Example: Minute
        ///     Enum: Minute, Hour, Day
        /// </summary>
        public string timeUnit { get; set; }
    }
}