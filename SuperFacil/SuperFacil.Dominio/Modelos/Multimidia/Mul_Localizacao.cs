﻿using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Multimidia
    {
    /* 
    * Propriedades Abstratas a ter em conta:
    * Designacao
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    */
    public class Mul_Localizacao : Abs_Base
        {

        #region Construtor
        public Mul_Localizacao()
            {
            this.Midia = new List<Mul_Midia>();
            }
        #endregion

        #region - Propriedade -
        public int Localizacao_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        #endregion

        #region Relacionamento
        public virtual ICollection<Mul_Midia> Midia { get; set; }
        #endregion

        #region Metodos
        public void Set_Localizacao(string _Designacao, int _Empresa_ID, int? _Parent_ID = null)
            {
            AssertionConcern.AssertArgumentLength(_Designacao, 500, Res_Base.TagNomeSize);
            this.Designacao = _Designacao;
            this.Empresa_ID = _Empresa_ID;
            this.Parent_ID = _Parent_ID;
            }
        #endregion

        }
    }
