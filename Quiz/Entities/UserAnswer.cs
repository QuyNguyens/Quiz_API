using System.ComponentModel.DataAnnotations;

namespace Quiz.Entities
{
    /// <summary>
    /// UserAnswer
    /// </summary>
    public class UserAnswer
    {
        /// <summary>
        /// Gets or sets the user answer identifier.
        /// </summary>
        /// <value>
        /// The user answer identifier.
        /// </value>
        [Key]
        public int UserAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the quiz attempt identifier.
        /// </summary>
        /// <value>
        /// The quiz attempt identifier.
        /// </value>
        public int QuizAttemptId { get; set; }

        /// <summary>
        /// Gets or sets the quiz attempt.
        /// </summary>
        /// <value>
        /// The quiz attempt.
        /// </value>
        public QuizAttempt QuizAttempt { get; set; }

        /// <summary>
        /// Gets or sets the question identifier.
        /// </summary>
        /// <value>
        /// The question identifier.
        /// </value>
        public int QuestionId { get; set; }

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        /// <value>
        /// The question.
        /// </value>
        public Question Question { get; set; }

        /// <summary>
        /// Gets or sets the answer identifier.
        /// </summary>
        /// <value>
        /// The answer identifier.
        /// </value>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets the answer.
        /// </summary>
        /// <value>
        /// The answer.
        /// </value>
        public Answer Answer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is correct.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is correct; otherwise, <c>false</c>.
        /// </value>
        public bool IsCorrect { get; set; }
    }
}
