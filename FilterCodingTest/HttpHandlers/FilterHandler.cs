using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using FilterNumberCodingTest.Interfaces;

namespace FilterNumberCodingTest
{
    public class FilterNumberHandler
    {
        private readonly INumberFilter _numberFilter;

        public FilterNumberHandler(INumberFilter numberFilter)
            => _numberFilter = numberFilter;

        [FunctionName("FilterNumberHandler")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "filter")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var queryStringValue = Convert.ToString(req.Query["value"]);

            // null check etc here
            var numbersToFilter = queryStringValue.Split(',').Select(int.Parse).ToList();

            var filteredNumbers = _numberFilter.ApplyFilter(numbersToFilter);

            return numbersToFilter != null
                ? (ActionResult)new OkObjectResult($"Values are {string.Join(',', filteredNumbers)}")
                : new BadRequestObjectResult("Please pass a value on the query string");
        }
    }
}
