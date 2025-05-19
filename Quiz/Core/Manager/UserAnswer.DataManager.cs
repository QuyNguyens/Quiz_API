using Quiz.Model.Dto;

namespace Quiz.Core.Manager
{
    /// <summary>
    /// UserAnswer DataManager
    /// </summary>
    public partial class DataManager
    {
        /// <summary>
        /// Creates the user answer.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public bool CreateUserAnswer(UserAnswerDto dto)
        {
            return this.UserAnswerFactory.CreateUserAnswer(dto);
        }
    }
}
