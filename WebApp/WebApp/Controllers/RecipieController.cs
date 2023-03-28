using Microsoft.AspNetCore.Mvc;
using Core.Services;
using DataLayer.Entities;
using Core.DTos;
using DataLayer.DTos;

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
        [HttpDelete("delete-recipie/{recipieId}")]
        public ActionResult<bool> DeleteRecipie(int recipieId)
        {
            if (_recipieService.DeleteRecipie(recipieId))
            {
                return true;
            }
            return BadRequest("Recipie not found!");
        }
        [HttpPost("create-recipie")]
        public ActionResult<bool> CreateRecipie([FromBody] RecipieCreateDto recipie)
        {
            if (_recipieService.CreateRecipie(recipie))
            {
                return true;
            }
            return BadRequest("Failed to create a new recipie");
        }
        [HttpGet("/get/{recipieId}")]
        public ActionResult<RecipieDto> GetById(int recipieId)
        {
            var result = _recipieService.GetById(recipieId);

            if (result == null)
            {
                return BadRequest("Recipie not fount");
            }

            return Ok(result);
        }
    }
}
