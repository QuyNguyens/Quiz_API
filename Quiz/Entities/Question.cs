using System.ComponentModel.DataAnnotations;

namespace Quiz.Entities
{
    /// <summary>
    /// Question model
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Gets or sets the question identifier.
        /// </summary>
        /// <value>
        /// The question identifier.
        /// </value>
        [Key]
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
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
