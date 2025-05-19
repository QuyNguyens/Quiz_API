using Microsoft.AspNetCore.Mvc;
using Quiz.Core.Manager;
using Quiz.Entities;
using Quiz.Model.Dto;

namespace Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizAttemptController : ControllerBase
    {
        /// <summary>
        /// The data manager
        /// </summary>
        private readonly DataManager dataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptController"/> class.
        /// </summary>
        /// <param name="dataManager">The data manager.</param>
        public QuizAttemptController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("quiz-attempt/{id}")]  
        public IActionResult GetById(int id)
        {
            QuizAttemptDto res = this.dataManager.GetById(id);

            return Ok(res);
        }

        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        [HttpPost("create-quiz-attempt")]
        public IActionResult CreateQuizAttempt()
        {
            QuizAttempt res = this.dataManager.CreateQuizAttempt();

            return Ok(res);
        }

        /// <summary>
        /// Updates the quiz attempt.
        /// </summary>
        /// <param name="req">The req.</param>
        /// <returns></returns>
        [HttpPost("update-quiz-attempt")]
        public IActionResult UpdateQuizAttempt([FromBody] QuizAttempt req)
        {
            bool res = this.dataManager.UpdateQuizAttempt(req);

            return Ok(res);
        }
    }
}
