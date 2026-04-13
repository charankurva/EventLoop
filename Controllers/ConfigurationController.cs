using EventLoop.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EventLoop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        //private readonly IConfiguration _configuration;
        //public ConfigurationController(IConfiguration configuration) { 
        //    _configuration = configuration;
        
        
        //}
        [HttpGet]
        public ActionResult GetMyKey(IOptions<DatabaseOptions> options)
        {
            var myKey = options.Value;
            return Ok(myKey.Type);

        }
        //[HttpGet("database")]
        //public ActionResult GetDatabase()
        //{
        //    var type = _configuration["Database:Type"];
        //    var db = _configuration["Database:ConnectionString"];
        //    return Ok(new { Type=type, ConnectionString =db });
        //}
    }
}
