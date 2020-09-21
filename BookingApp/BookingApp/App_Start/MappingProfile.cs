using AutoMapper;
using BookingApp.Dtos;
using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Stay, StayDto>();
            Mapper.CreateMap<StayDto, Stay>();
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<Country, CountryDto>();
            Mapper.CreateMap<PropertyType, PropertyTypeDto>();
            
        }
    }
}