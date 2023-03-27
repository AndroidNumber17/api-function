using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServerlessApi.Models;

namespace ServerlessApi.Interfaces;

public interface ICar
{
    Task<IEnumerable<Car>> GetCarsAsync();
    Task AddCarAsync(Car car);
}