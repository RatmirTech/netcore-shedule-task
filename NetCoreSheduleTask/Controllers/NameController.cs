using Microsoft.AspNetCore.Mvc;

namespace NetCoreSheduleTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
{
        "Петя, Вася, Никита"
    };

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetNames")]
        public IEnumerable<string> Get()
        {
            var list = Summaries.ToList();
            return list;
        }
    }
}
