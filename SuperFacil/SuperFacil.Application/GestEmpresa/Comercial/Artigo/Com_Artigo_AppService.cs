﻿using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo_AppService : IAppServiceBase<Com_Artigo>, ICom_Artigo_AppService
    {
        public void Delete(Com_Artigo _obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Com_Artigo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Com_Artigo> GetID(int _ID)
        {
            throw new NotImplementedException();
        }

        public void Create(Com_Artigo _obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Com_Artigo _obj)
        {
            throw new NotImplementedException();
        }
    }
}
