using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace ImageProcessing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiKeysController : ControllerBase
    {
        private static readonly ConcurrentDictionary<string, bool> ApiKeys = new();

        [HttpPost("generate")]
        public IActionResult GenerateApiKey()
        {
            var apiKey = Guid.NewGuid().ToString();
            ApiKeys[apiKey] = true;
            return Ok(new { apiKey });
        }

        public static bool IsValidApiKey(string apiKey) => ApiKeys.ContainsKey(apiKey);
    }
}

