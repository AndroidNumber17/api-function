using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ServerlessApi.Interfaces;
using ServerlessApi.Models;

namespace ServerlessApi.Api.CarFunctions;

public class GetCars
{
    private readonly ICar carService;

    public GetCars(ICar carService)
    {
        this.carService = carService;
    }

    [FunctionName("GetCars")]
    public async Task<IActionResult> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "cars")]
        HttpRequest req, ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        //var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        //var data = JsonConvert.DeserializeObject<IEnumerable<Car>>(requestBody);
        
        var cars = await carService.GetCarsAsync();
        return new OkObjectResult(cars);
    }
}