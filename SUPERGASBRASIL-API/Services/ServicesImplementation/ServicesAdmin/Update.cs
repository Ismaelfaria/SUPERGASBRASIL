﻿using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Update : IUpdateServ
    {
        private readonly IUpdateA UpdateAdm;
        public Update(IUpdateA updateAdm)
        {
            UpdateAdm = updateAdm;
        }
        public void UpdateAdmin(string userName, Admin admin)
        {
            UpdateAdm.UpdateAdmin(userName, admin);
        }
    }
}
