﻿using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural
{
    public class GetClientN : IGetClientN
    {
        private readonly GasContext _context;
        public GetClientN(GasContext context)
        {
            _context = context;
        }
        public IEnumerable<ClientNaturalPerson> FindAll()
        {
            throw new NotImplementedException();
        }

        public ClientNaturalPerson FindByCpf(int cpf)
        {
            throw new NotImplementedException();
        }

        public ClientNaturalPerson FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}