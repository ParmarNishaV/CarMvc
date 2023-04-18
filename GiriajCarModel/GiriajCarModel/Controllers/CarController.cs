using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core;
using GiriajCarModel.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace GiriajCarModel.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService,IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet("GetCars")]
        public async Task<IActionResult> GetAllCarAsync()
        {
            return Json(new { data = await _carService.GetAllCarAsync() });
        }

        [HttpPost]
        public async Task<IActionResult> GetCarBySearchString([FromBody] SearchModel model)
        {
            return Ok(await _carService.GetCarByBrandAndModel(model.q));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            return Ok(await _carService.GetCarByIdAsync(id));
        }

        [HttpPost("AddCarModel")]
        public async Task<IActionResult> AddCar([FromForm] CarModel carModel )
        {
            var car = _mapper.Map<Car>(carModel);
            await _carService.AddCarAsync(car);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCar([FromBody] CarModel carModel)
        {
            var car = _mapper.Map<Car>(carModel);
            _carService.EditCar(car);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            if(car != null)
            {
                _carService.DeleteCar(car);
                return Ok();
            }
            return NotFound();

        }
    }
}

