using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quiz.Core.Manager;
using Quiz.Model.Dto;

namespace Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        /// <summary>
        /// The data manager
        /// </summary>
        private readonly DataManager dataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionController"/> class.
        /// </summary>
        /// <param name="dataManager">The data manager.</param>
        public QuestionController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /// <summary>
        /// Creates the question.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        [HttpPost("create-question")]
        public IActionResult CreateQuestion([FromBody] QuestionDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Content) || dto.Answers == null || !dto.Answers.Any())
            {
                return BadRequest("Invalid data.");
            }

            if (dto.Answers.Count(a => a.IsCorrect) != 1)
            {
                return BadRequest("Each question must have exactly one correct answer.");
            }

            bool result = this.dataManager.CreateQuestion(dto);

            if(result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Gets the questions.
        /// </summary>
        /// <returns></returns>
        [HttpGet("questions")]
        [AllowAnonymous]
        public IActionResult GetQuestions()
        {
            List<QuestionDto> res = this.dataManager.GetQuestions();

            return Ok(res);
        }
    }
}
