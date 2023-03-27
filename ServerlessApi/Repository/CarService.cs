using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerlessApi.Database;
using ServerlessApi.Interfaces;
using ServerlessApi.Models;

namespace ServerlessApi.Repository;

public class CarService : ICar
{
    private readonly DataContext context;

    public CarService(DataContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<Car>> GetCarsAsync()
    {
        return await context.Car.ToListAsync();
    }

    public async Task AddCarAsync(Car car)
    {
        await context.Car.AddAsync(car);
        await context.SaveChangesAsync();
    }
}