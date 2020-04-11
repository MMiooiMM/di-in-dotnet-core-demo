using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("Add/{a}/{b}")]
        public int AddTwoNumber(int a, int b) => _testService.Add(a, b);
    }
}
