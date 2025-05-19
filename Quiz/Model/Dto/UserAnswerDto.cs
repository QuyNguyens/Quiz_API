namespace Quiz.Model.Dto
{
    /// <summary>
    /// UserAnswer Dto
    /// </summary>
    public class UserAnswerDto
    {
        /// <summary>
        /// Gets or sets the attempt identifier.
        /// </summary>
        /// <value>
        /// The attempt identifier.
        /// </value>
        public int AttemptId { get; set; }

        /// <summary>
        /// Gets or sets the question identifier.
        /// </summary>
        /// <value>
        /// The question identifier.
        /// </value>
        public int QuestionId { get; set; }

        /// <summary>
        /// Gets or sets the answer identifier.
        /// </summary>
        /// <value>
        /// The answer identifier.
        /// </value>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is correct.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is correct; otherwise, <c>false</c>.
        /// </value>
        public bool IsCorrect { get; set; }
    }
}
