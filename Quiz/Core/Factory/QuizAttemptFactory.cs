using Microsoft.EntityFrameworkCore;
using Quiz.Data;
using Quiz.Entities;
using Quiz.Model.Dto;

namespace Quiz.Core.Factory
{
    /// <summary>
    /// QuizAttempt Factory
    /// </summary>
    public class QuizAttemptFactory
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly QuizDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionFactory"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QuizAttemptFactory(QuizDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates the specified attempt.
        /// </summary>
        /// <returns></returns>
        public QuizAttempt CreateQuizAttempt()
        {
            QuizAttempt quiz = new QuizAttempt();

            this.context.QuizAttempt.Add(quiz);
            this.context.SaveChanges();

            return quiz;
        }

        /// <summary>
        /// Updates the quiz attempt.
        /// </summary>
        /// <param name="req">The req.</param>
        /// <returns></returns>
        public bool UpdateQuizAttempt(QuizAttempt req)
        {
            var existing = this.context.QuizAttempt
               .FirstOrDefault(x => x.AttemptId == req.AttemptId);

            if (existing == null)
                return false;

            existing.EndTime = DateTime.Now;

            return this.context.SaveChanges() > 0;
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public QuizAttemptDto GetById(int id)
        {
            var attempt = context.QuizAttempt
                .Include(x => x.UserAnswers)
                .FirstOrDefault(x => x.AttemptId == id);

            var dto = new QuizAttemptDto
            {
                StartTime = attempt.StartTime,
                EndTime = attempt.EndTime,
                UserAnswers = attempt.UserAnswers.Select(ua => new UserAnswerDto
                {
                    QuestionId = ua.QuestionId,
                    AnswerId = ua.AnswerId,
                    IsCorrect = ua.IsCorrect
                }).ToList()
            };

            return dto;
        }
    }
}
