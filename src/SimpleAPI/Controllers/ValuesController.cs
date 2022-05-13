using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"value1", "value2"};
    }
     //GET api/values
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "stephanie";
    }
    // POST api/values   
    [HttpPost]
    public void Post ([FromBody] string value)
    {

    }
}
