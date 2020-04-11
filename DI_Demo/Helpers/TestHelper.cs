using DI_Demo.Models;
using Microsoft.Extensions.Options;

namespace DI_Demo.Helpers
{
    public class TestHelper
    {
        private readonly TestConfig _testConfig;

        public TestHelper(IOptions<TestConfig> options)
        {
            _testConfig = options.Value;
        }

        public string DoSomthingAndGetValue() => _testConfig.Value;
    }
}