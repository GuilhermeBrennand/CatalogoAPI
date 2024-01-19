using Catalogo.Application.UseCases;
using Catalogo.Communication.Request;
using Catalogo.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromServices] IUseCaseCreateMovie movie, [FromBody] RequestMovie request)
        {
            movie.Execute(request);

            return CreatedAtAction(nameof(Create), movie, request);
        }
    }
}
