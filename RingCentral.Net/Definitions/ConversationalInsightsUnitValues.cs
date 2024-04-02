namespace RingCentral
{
    public class ConversationalInsightsUnitValues
    {
        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     Required
        ///     Example: RingCentral
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 4.7
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 5.1
        /// </summary>
        public decimal? end { get; set; }

        /// <summary>
        ///     Paragraph index of the long summary.
        ///     Example: 0
        /// </summary>
        public string groupId { get; set; }

        /// <summary>
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     Example: Speaker
        /// </summary>
        public string assignee { get; set; }

        /// <summary>
        ///     Example: NextStep
        /// </summary>
        public string category { get; set; }

        /// <summary>
        ///     Example: All right, now let us go down to a CD settings.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Example: So so you want me to add it to the B D as well?
        /// </summary>
        public string question { get; set; }

        /// <summary>
        ///     Example: Or or you can add another tab and have it resigned.
        /// </summary>
        public string answer { get; set; }
    }
}