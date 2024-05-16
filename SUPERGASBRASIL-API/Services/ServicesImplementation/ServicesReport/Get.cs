﻿using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesReport
{
    public class Get : IGet
    {
        private readonly GasContext _context;
        public Get(GasContext context)
        {
            _context = context;
        }
        public IEnumerable<GeneralReport> FindAll()
        {
            var usersDatabase = _context.GeneralReport.ToList();

            return usersDatabase;
        }

        public GeneralReport FindByDateGenerated(DateTime dataRelatorio)
        {
            var userDatabase = _context.GeneralReport.SingleOrDefault(a => a.DateGenerated == dataRelatorio);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
