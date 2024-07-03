using AutoMapper;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Domain.PIT;

namespace SUPERGASBRASIL_API.App.Mapping.Profiles
{
    public class ProfileMapperGas : Profile
    {
        public ProfileMapperGas()
        {
            CreateMap<Admin, Admin_InputModel>().ReverseMap();
            CreateMap<ClientLegalEntity, ClientLegal_InputModel>().ReverseMap();
            CreateMap<ClientNaturalPerson, ClientNatural_InputModel>().ReverseMap();
            CreateMap<Employees, Employees_InputModel>().ReverseMap();
            CreateMap<User, User_InputModel>().ReverseMap();
            CreateMap<Product, Product_InputModel>().ReverseMap();
            CreateMap<Inventory, Inventory_InputModel>().ReverseMap();
        }
    }
}
