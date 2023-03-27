using Microsoft.AspNetCore.Mvc;
using Core.Services;
using DataLayer.Entities;

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
    }
}
