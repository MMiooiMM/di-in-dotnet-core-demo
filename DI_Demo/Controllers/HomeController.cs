using DI_Demo.Helpers;
using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly TestHelper _testHelper;

        public HomeController(ITestService testService, TestHelper testHelper)
        {
            _testService = testService;
            _testHelper = testHelper;
        }

        [HttpGet("add/{a}/{b}")]
        public int AddTwoNumber(int a, int b) => _testService.Add(a, b);

        [HttpGet("testconfig")]
        public string GetTestConfigValue() => _testHelper.DoSomthingAndGetValue();
    }
}