using DI_Demo.Models;
using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DI_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly TestConfig _testConfig;

        public HomeController(ITestService testService, IOptions<TestConfig> options)
        {
            _testService = testService;
            _testConfig = options.Value;
        }

        [HttpGet("add/{a}/{b}")]
        public int AddTwoNumber(int a, int b) => _testService.Add(a, b);

        [HttpGet("testconfig")]
        public string GetTestConfigValue() => _testConfig.Value;
    }
}