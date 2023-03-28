using Microsoft.AspNetCore.Mvc;
using Core.Services;
using DataLayer.Entities;
using Core.DTos;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/recipies")]
    public class RecipieController : ControllerBase
    {
        private RecipieService _recipieService { get; set; }
        public RecipieController(RecipieService recipieService)
        {
            _recipieService = recipieService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Recipie>> GetAll()
        {
            var results = _recipieService.GetAll();
            return Ok(results);
        }
        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] RecipieUpdateDto studentUpdateModel)
        {
            var result = _recipieService.EditName(studentUpdateModel);

            if (!result)
            {
                return BadRequest("Student could not be updated.");
            }

            return result;
        }
    }
}
