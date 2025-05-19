using Quiz.Data;
using Quiz.Entities;
using Quiz.Model.Dto;

namespace Quiz.Core.Factory
{
    /// <summary>
    /// UserAnswer Factory
    /// </summary>
    public class UserAnswerFactory
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly QuizDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAnswerFactory"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserAnswerFactory(QuizDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates the user answer.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public bool CreateUserAnswer(UserAnswerDto dto)
        {
            UserAnswer userAnswer = new UserAnswer()
            {
                QuizAttemptId = dto.AttemptId,
                QuestionId = dto.QuestionId,
                AnswerId = dto.AnswerId,
                IsCorrect = dto.IsCorrect,
            };

            this.context.UserAnswer.Add(userAnswer);
            return this.context.SaveChanges() > 0;
        }
    }
}
