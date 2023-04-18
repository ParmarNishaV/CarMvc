using System;
using Core;
using Data;

namespace Service
{
    public class CarService : ICarService
    {
        private readonly IEntityRepository<Car> _carRepository;

        public CarService(IEntityRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IList<Car>> GetAllCarAsync()
        {
           var a= await _carRepository.GetEntitiesAsync();
            return a;
        }

        public async Task<IList<Car>> GetCarByBrandAndModel(string name)
        {
            return await _carRepository.GetEntitiesAsync(x => x.Brand.Contains(name) || x.Model.Contains(name));
        }

        public async Task<Car> GetCarByIdAsync(int Id)
        {
            return (await _carRepository.GetEntitiesAsync(x => x.Id == Id)).First();
        }

        public async Task AddCarAsync(Car car)
        {
            await _carRepository.AddEntityAsync(car);
        }

        public void EditCar(Car car)
        {
            _carRepository.UpdateEntity(car);
        }

        public void DeleteCar(Car car)
        {
            _carRepository.DeleteEntity(car);
        }

    }
}

