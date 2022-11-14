namespace ApiBasics.Controllers;

public class StatusController : ControllerBase
{
    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        return Ok("All looks good.");
    }
}
