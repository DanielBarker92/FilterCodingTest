using FilterCodingTest.Filter.Interfaces;
using FilterCodingTest.Filter.PrimeNumberFilterService;
using FilterCodingTest.Sort.BubbleSort;
using FilterCodingTest.Sort.Interfaces;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FilterNumberCodingTest.Startup))]

namespace FilterNumberCodingTest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<INumberFilter, RemovePrimeNumberFilter>();
            builder.Services.AddSingleton<ISort, BubbleSort>();

        }
    }
}
