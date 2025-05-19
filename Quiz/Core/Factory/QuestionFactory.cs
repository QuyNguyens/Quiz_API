using Microsoft.EntityFrameworkCore;
using Quiz.Data;
using Quiz.Entities;
using Quiz.Model.Dto;

namespace Quiz.Core.Factory
{
    /// <summary>
    /// Question factory
    /// </summary>
    public class QuestionFactory
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly QuizDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionFactory"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QuestionFactory(QuizDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates the question.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public bool CreateQuestion(QuestionDto dto)
        {
            var question = new Question
            {
                Content = dto.Content,
                Answers = dto.Answers.Select(a => new Answer
                {
                    Content = a.Content,
                    IsCorrect = a.IsCorrect
                }).ToList()
            };

            this.context.Question.Add(question);
            return this.context.SaveChanges() > 0;
        }

        /// <summary>
        /// Gets the questions.
        /// </summary>
        /// <returns></returns>
        public List<QuestionDto> GetQuestions()
        {
            return this.context.Question
                .Include(q => q.Answers)
                .Take(10)
                .Select(q => new QuestionDto
                {
                    QuestionId = q.QuestionId,
                    Content = q.Content,
                    Answers = q.Answers.Select(a => new AnswerDto
                    {
                        AnswerId = a.AnswerId,
                        Content = a.Content,
                        IsCorrect = a.IsCorrect
                    }).ToList()
                })
                .ToList();
        }
    }
}
