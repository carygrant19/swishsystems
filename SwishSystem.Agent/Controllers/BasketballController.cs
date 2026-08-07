using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwishSystem.Agent.Services.IService;

namespace SwishSystem.Agent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketballController(IBasketballService basketballService) : ControllerBase
    {
        private readonly IBasketballService _basketballService = basketballService;

        [HttpPost("reportGenerate")]
        public async Task<IActionResult> ReportGenerate(string request)
        {
            try
            {
                var result = await _basketballService.GenerateReport(request);

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
