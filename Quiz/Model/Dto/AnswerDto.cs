namespace Quiz.Model.Dto
{
    /// <summary>
    /// AnswerDto
    /// </summary>
    public class AnswerDto
    {
        /// <summary>
        /// Gets or sets the answer identifier.
        /// </summary>
        /// <value>
        /// The answer identifier.
        /// </value>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is correct.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is correct; otherwise, <c>false</c>.
        /// </value>
        public bool IsCorrect { get; set; }
    }
}
