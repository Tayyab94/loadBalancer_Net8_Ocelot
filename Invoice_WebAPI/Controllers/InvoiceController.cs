using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoice_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            await Task.Delay(100);
            return new string[] { "Dhananjay", "Nidhish", "Vijay", "Nazim", "Alpesh" };
        }
    }
}
