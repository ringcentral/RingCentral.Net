namespace RingCentral
{
    public class FixedAnswerModel
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
    }
}