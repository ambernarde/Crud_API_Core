using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelEntityProfile : Profile
    {   
        public ModelEntityProfile()
        {
            CreateMap<UserModel,UserEntity>()
            .ReverseMap();

            CreateMap<UfModel,UfEntity>()
            .ReverseMap();

            CreateMap<MunicipioModel,MunicipioEntity>()
            .ReverseMap();

            CreateMap<CepModel,CepEntity>()
            .ReverseMap();
            
        }
    }
}