using Microsoft.AspNetCore.Mvc;
using Chasing.Lobster.Domain.catalog;

namespace Chasing.Lobster.Api.Controllers{
    [ApiController]
    [Route("[controller]")]

    public class CatalogController: ControllerBase{
        [HttpGet]
        public IActionResult GetItems(){
            return Ok("Hello World!");
        }
    }
    
}