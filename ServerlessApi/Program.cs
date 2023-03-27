
using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServerlessApi.Database;
using ServerlessApi.Interfaces;
using ServerlessApi.Repository;

[assembly: FunctionsStartup(typeof(ServerlessApi.Program))]
namespace ServerlessApi;

public class Program : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        var config = builder.GetContext().Configuration;
        builder.Services.AddDbContext<DataContext>(x => x.UseNpgsql(
        Environment.GetEnvironmentVariable("connectionString", EnvironmentVariableTarget.Process)!));
        builder.Services.AddScoped<ICar, CarService>();
    }
}