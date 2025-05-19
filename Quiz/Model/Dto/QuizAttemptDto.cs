
namespace Quiz.Model.Dto
{
    /// <summary>
    /// QuizAttempt Dto
    /// </summary>
    public class QuizAttemptDto
    {
        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the user answers.
        /// </summary>
        /// <value>
        /// The user answers.
        /// </value>
        public ICollection<UserAnswerDto> UserAnswers { get; set; } = new List<UserAnswerDto>();

        /// <summary>
        /// Gets the correct answers count.
        /// </summary>
        /// <value>
        /// The correct answers count.
        /// </value>
        public int CorrectAnswersCount => UserAnswers.Count(a => a.IsCorrect);
    }
}
