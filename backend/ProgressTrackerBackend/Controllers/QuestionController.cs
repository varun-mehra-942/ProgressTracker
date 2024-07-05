using Microsoft.AspNetCore.Mvc;
using DTOS;
using Entities;

namespace Controllers
{

    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        static List<Question> records = new List<Question>();
        [HttpPost]
        public IActionResult AddQuestion(RecordDTO record)
        {
            records.Add(new Question()
            {
                QuestionId = Guid.NewGuid().ToString(),
                Link = record.Link,
                Name = record.Name,
                Status = record.Status
            });
            return Ok(record);
        }

        [HttpPut]
        public IActionResult UpdateQuestion(RecordDTO record)
        {
            return Ok();

        }

        [HttpGet]
        public IActionResult GetAllQuestions()
        {
            return Ok(records);
        }

    }

}
