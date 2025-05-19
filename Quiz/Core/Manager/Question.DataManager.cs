using Quiz.Model.Dto;

namespace Quiz.Core.Manager
{
    /// <summary>
    /// Question DataManager
    /// </summary>
    public partial class DataManager
    {
        /// <summary>
        /// Creates the question.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public bool CreateQuestion(QuestionDto dto)
        {
            return this.QuestionFactory.CreateQuestion(dto);
        }

        /// <summary>
        /// Gets the questions.
        /// </summary>
        /// <returns></returns>
        public List<QuestionDto> GetQuestions()
        {
            return this.QuestionFactory.GetQuestions();
        }
    }
}
