using Microsoft.AspNetCore.Mvc;
using DTOS;

namespace RecordCRUD
{

    [ApiController]
    [Route("record")]
    public class RecordController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddRecord(RecordDTO record)
        {

            return Ok(record);
        }

    }

}
