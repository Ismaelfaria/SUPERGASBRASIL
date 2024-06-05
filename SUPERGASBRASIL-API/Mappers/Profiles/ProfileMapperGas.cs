using AutoMapper;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Mappers.Profiles
{
    public class ProfileMapperGas : Profile
    {
        public ProfileMapperGas()
        {
            CreateMap<Admin, Admin_InputModel>().ReverseMap();
            CreateMap<ClientLegalEntity, ClientLegal_InputModel>().ReverseMap();
            CreateMap<ClientNaturalPerson, ClientNatural_InputModel>().ReverseMap();
            CreateMap<Employees, Employees_InputModel>().ReverseMap();
            CreateMap<User, Login_InputModel>().ReverseMap();
        }
    }
}
