using Microsoft.AspNetCore.Mvc;

namespace ex2_backend.Controllers
{
  [Route("api/")]
  [ApiController]
  public class CambioController : ControllerBase
  {
    // ejemplo del PI
    /*
    [HttpGet]
    [Route("benefits")]
    public ActionResult GetBenefits(string projectName, string employerID)
    {
      try
      {
        var handler = new BenefitsHandler();
        var data = handler.GetBenefitsData(projectName, employerID);
        return Ok(data);
      }
      catch (Exception error)
      {
        Console.WriteLine(error);
        return BadRequest(error.Message);
      }
    }
    */

  }
}
