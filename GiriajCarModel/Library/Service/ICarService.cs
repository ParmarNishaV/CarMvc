using System;
using Core;

namespace Service
{
    public interface ICarService
    {
        Task<IList<Car>> GetAllCarAsync();
        Task<IList<Car>> GetCarByBrandAndModel(string name);
        Task<Car> GetCarByIdAsync(int Id);
        Task AddCarAsync(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);
    }
}

