﻿using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales
{
    public interface IGet
    {
        IEnumerable<Sales> FindAll();
        Sales FindById(Guid id);
        Sales FindByDateSale(DateTime DateSale);
    }
}
