using Microsoft.AspNetCore.Mvc;
using Quiz.Core.Manager;
using Quiz.Model.Dto;

namespace Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {
        /// <summary>
        /// The data manager
        /// </summary>
        private readonly DataManager dataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAnswerController"/> class.
        /// </summary>
        /// <param name="dataManager">The data manager.</param>
        public UserAnswerController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        [HttpPost("user-answer")]
        public IActionResult Create([FromBody]UserAnswerDto dto)
        {
            if(dto == null)
            {
                return BadRequest("Invalid");
            }

            var res = this.dataManager.CreateUserAnswer(dto);

            return Ok(res);
        }
    }
}
