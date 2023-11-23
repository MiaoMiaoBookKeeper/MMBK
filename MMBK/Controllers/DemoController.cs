using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMBK.Core.Contract;
using System.Threading.Tasks;

namespace MMBK.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DemoController : ControllerBase
  {
    private IDemoService _demoService;
    public DemoController(IDemoService demoService)
    {
          _demoService = demoService;
    }

    [HttpGet()]
    public async Task<IActionResult> Get(int id)
    {
      var result = await _demoService.GetAsync();
      return Ok(result);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> Add(int id)
    {
      var result = await _demoService.AddAsync(id);
      return Ok(result);
    }


  }
}
