using AutoMapper;
using Juros.Models.Dtos;
using Juros.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juros.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Dto to Entity
            CreateMap<JuroDto, Juro>();

            // Entity to Dto
            CreateMap<Juro, JuroDto>();
        }
    }
}
