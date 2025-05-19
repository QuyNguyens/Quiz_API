using System.ComponentModel.DataAnnotations;

namespace Quiz.Entities
{
    /// <summary>
    /// QuizAttempt model
    /// </summary>
    public class QuizAttempt
    {
        /// <summary>
        /// Gets or sets the attempt identifier.
        /// </summary>
        /// <value>
        /// The attempt identifier.
        /// </value>
        [Key]
        public int AttemptId { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime StartTime { get; set; } = DateTime.Now;

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
        public ICollection<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();

        /// <summary>
        /// Gets the correct answers count.
        /// </summary>
        /// <value>
        /// The correct answers count.
        /// </value>
        public int CorrectAnswersCount => UserAnswers.Count(a => a.IsCorrect);
    }
}
