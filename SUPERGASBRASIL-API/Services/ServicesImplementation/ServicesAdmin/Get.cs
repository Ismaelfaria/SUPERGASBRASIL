﻿using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Get : IGet
    {
        private readonly GasContext _context;
        public Get(GasContext context)
        {
            _context = context;
        }
        public IEnumerable<Admin> FindAll()
        {
            var usersDatabase = _context.Admin.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Admin FindByUserName(string name)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.Username == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
