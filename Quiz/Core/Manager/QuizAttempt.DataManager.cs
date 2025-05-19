using Quiz.Entities;
using Quiz.Model.Dto;

namespace Quiz.Core.Manager
{
    public partial class DataManager
    {
        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public QuizAttempt CreateQuizAttempt()
        {
            return this.QuizAttemptFactory.CreateQuizAttempt();
        }

        /// <summary>
        /// Updates the quiz attempt.
        /// </summary>
        /// <param name="req">The req.</param>
        /// <returns></returns>
        public bool UpdateQuizAttempt(QuizAttempt req)
        {
            return this.QuizAttemptFactory.UpdateQuizAttempt(req);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public QuizAttemptDto GetById(int id)
        {
            return this.QuizAttemptFactory.GetById(id);
        }
    }
}
