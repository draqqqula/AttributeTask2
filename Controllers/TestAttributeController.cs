using AttributeTask2.Controllers.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AttributeTask2.Controllers
{
    /// <summary>
    /// Контроллер для валидации null и default value
    /// </summary>
    [Route("validate-null")]
    public class TestAttributeController : Controller
    {
        [HttpPost("test")]
        public IActionResult TestAsync([FromBody] TestDto testDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}