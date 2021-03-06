﻿using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Repositories.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Services.Inquerito
{
    public class Inq_Inquerito_Pergunta_Service : ServiceBase<Inq_Inquerito_Pergunta>, IInq_Inquerito_Pergunta_Service
    {
        private readonly IInq_Inquerito_Pergunta_Repository _Repository;

        public Inq_Inquerito_Pergunta_Service(IInq_Inquerito_Pergunta_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }       
    }
}
