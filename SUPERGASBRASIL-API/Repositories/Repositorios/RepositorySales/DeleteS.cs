﻿using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales
{
    public class DeleteS : IDeleteS
    {
        private readonly GasContext _context;
        public DeleteS(GasContext context)
        {
            _context = context;
        }
        public void DeleteSales(Guid id)
        {
            var userDatabase = _context.Sales.SingleOrDefault(a => a.IdSales == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}