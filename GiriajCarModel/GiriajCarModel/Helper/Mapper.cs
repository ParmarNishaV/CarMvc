using System;
using AutoMapper;
using Core;
using GiriajCarModel.Models;

namespace GiriajCarModel.Helper
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<CarModel, Car>().ReverseMap();
		}
	}
}

