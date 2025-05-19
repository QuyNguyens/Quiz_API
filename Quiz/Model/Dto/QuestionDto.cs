namespace Quiz.Model.Dto
{
    /// <summary>
    /// QuestionDto
    /// </summary>
    public class QuestionDto
    {
        /// <summary>
        /// Gets or sets the question identifier.
        /// </summary>
        /// <value>
        /// The question identifier.
        /// </value>
        public int QuestionId { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the answers.
        /// </summary>
        /// <value>
        /// The answers.
        /// </value>
        public List<AnswerDto> Answers { get; set; } = new();
    }
}
