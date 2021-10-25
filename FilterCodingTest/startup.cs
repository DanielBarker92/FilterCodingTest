using FilterCodingTest.Filter.Interfaces;
using FilterCodingTest.Filter.PrimeNumberFilterService;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(FilterNumberCodingTest.Startup))]

namespace FilterNumberCodingTest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<INumberFilter, RemovePrimeNumberFilter>();
        }
    }
}
