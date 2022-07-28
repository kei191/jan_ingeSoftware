using Microsoft.AspNetCore.Mvc;
using ex2_backend.Models;
using ex2_backend.Handlers;

namespace ex2_backend.Controllers
{
  [Route("api/")]
  [ApiController]
  public class RefrescosController : ControllerBase
  {
    [HttpGet]
    [Route("refrescos")]
    public ActionResult GetRefrescos()
    {
      try
      {
        var data = RefrescosHandler.GetRefrescos();
        return Ok(data);
      }
      catch (Exception error)
      {
        Console.WriteLine(error);
        return BadRequest(error.Message);
      }
    }
  }
}
