namespace RingCentral
{
    public class VariableAnswerModel
    {
        /// <summary>
        ///     ID of the custom question
        ///     Required
        ///     Example: 123456789
        /// </summary>
        public string questionId { get; set; }

        /// <summary>
        ///     Answer text
        ///     Required
        /// </summary>
        public string answerText { get; set; }
    }
}