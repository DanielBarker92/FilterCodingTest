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
using FilterCodingTest.Filter.Interfaces;
using FilterCodingTest.Sort.Interfaces;

namespace FilterNumberCodingTest
{
    public class FilterNumberHandler
    {
        private readonly INumberFilter _numberFilter;
        private readonly ISort _sortService;

        public FilterNumberHandler(INumberFilter numberFilter, ISort sortService)
        {
            _numberFilter = numberFilter;
            _sortService = sortService;
        }

        [FunctionName("FilterNumberHandler")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "filter")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // This will likely be cleaned up or done another way depending on use-case
            var queryStringValue = Convert.ToString(req.Query["value"]);
            if (string.IsNullOrWhiteSpace(queryStringValue))
                return new BadRequestObjectResult("Please pass a comma separated list of values via the 'value' query string parameter");

            // TryParse strips out strings
            var numbersToFilter = queryStringValue.Split(',').Where(x => int.TryParse(x, out _)).Select(int.Parse).ToList();

            // Service to apply the injected filter and injected sort.
            var filteredNumbers = _numberFilter.ApplyFilter(numbersToFilter);
            var sortedNumbers = _sortService.OrderBy(filteredNumbers);

            return new OkObjectResult($"{string.Join(',', sortedNumbers)}");
        }
    }
}
