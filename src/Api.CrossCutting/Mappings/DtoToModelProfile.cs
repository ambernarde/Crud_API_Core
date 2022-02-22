using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;
using Domain.Dtos.User;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User

            CreateMap<UserModel,UserDto>()
            .ReverseMap();

            CreateMap<UserEntity, UserDto>()
            .ReverseMap();

            CreateMap<UserModel, UserDtoCreate>()
            .ReverseMap();

            CreateMap<UserModel, UserDtoUpdate>()
            .ReverseMap();
           
           #endregion

            #region Uf_Model

              CreateMap<UfModel,UfDto>()
              .ReverseMap();

            #endregion

            #region Municipio_Model

            CreateMap<MunicipioModel , MunicipioDto>()
            .ReverseMap();

            CreateMap<MunicipioModel, MunicipioDtoCreate>()
            .ReverseMap();

            CreateMap<MunicipioModel, MunicipioDtoUpdate>()
            .ReverseMap();             

           #endregion

            #region Cep_Model

            CreateMap<CepModel,CepDto>()
            .ReverseMap();

            CreateMap<CepModel,CepDtoCreate>()
            .ReverseMap();

            CreateMap<CepModel,CepDtoUpdate>()
            .ReverseMap();

           #endregion
           
        }
    }
}