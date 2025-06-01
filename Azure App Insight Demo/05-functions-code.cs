#r "Newtonsoft.Json"

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
	log.LogInformation("C# HTTP trigger function processed a request.");

	return new OkObjectResult("Hello Azure!");
}