﻿using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Get : IGetServ
    {
        private readonly  IGet GetAdmin;
        public Get(IGet getAdmin)
        {
            GetAdmin = getAdmin;
        }
        public IEnumerable<Admin> FindAll()
        {
            var Dados = GetAdmin.FindAll();

            return Dados;
        }

        public Admin FindByUserName(string name)
        {
            var Dados = GetAdmin.FindByUserName(name);

            return Dados;
        }
    }
}
