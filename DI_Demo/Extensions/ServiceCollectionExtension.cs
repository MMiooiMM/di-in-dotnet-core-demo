using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_Demo.Helpers;
using DI_Demo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Demo.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddTestHelper(this IServiceCollection serviceCollection, Action<TestConfig> options)
        {
            serviceCollection.AddScoped<TestHelper>();

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options), @"Please provide options for TestHelper.");
            }

            serviceCollection.Configure(options);
            return serviceCollection;
        }
    }
}
