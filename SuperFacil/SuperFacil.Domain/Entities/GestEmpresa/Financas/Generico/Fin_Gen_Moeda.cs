﻿using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Financas.Generico
{
    public class Fin_Gen_Moeda
    {
        public int Moeda_ID { get; set; }
        public string Sigla { get; set; }
        public string Designacao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool DefaultSystem { get; set; } = false;

    }
}
