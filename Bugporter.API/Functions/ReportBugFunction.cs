using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Bugporter.API.Functions;

public class ReportBugFunction
{
    private readonly ILogger<ReportBugFunction> _logger;

    public ReportBugFunction(ILogger<ReportBugFunction> logger)
    {
        _logger = logger;
    }

    [FunctionName(nameof(ReportBugFunction))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "bugs")] HttpRequest req)
    {

        return new OkResult();
    }
}
