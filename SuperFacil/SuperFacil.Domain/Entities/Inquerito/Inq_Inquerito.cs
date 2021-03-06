﻿using SuperFacil.Domain.Entities.Sistema;
using System;
using System.Collections.Generic;

namespace SuperFacil.Domain.Entities.Inquerito
{
    public class Inq_Inquerito
    {
        #region - Propredade -
        public int Inqueito_ID { get; set; }
        public int Empresa_ID { get; set; }
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
        #endregion

        #region - Relacionamento -
        public virtual Sis_Empresa Empresa { get; set; }
        public virtual ICollection<Inq_Inquerito_Pergunta_Categoria> Inquerito_Pergunta_Categoria { get; set; }
        public virtual ICollection<Inq_Questionario> Questionario { get; set; }
        #endregion
    }
}
