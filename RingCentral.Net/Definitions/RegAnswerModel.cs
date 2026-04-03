namespace RingCentral
{
    public class RegAnswerModel
    {
        /// <summary>
        ///     ID of the custom question
        ///     Required
        ///     Example: 123456789
        /// </summary>
        public string questionId { get; set; }

        /// <summary>
        ///     The list of answer IDs
        ///     Required
        /// </summary>
        public string[] answerIds { get; set; }

        /// <summary>
        ///     Answer text
        ///     Required
        /// </summary>
        public string answerText { get; set; }
    }
}