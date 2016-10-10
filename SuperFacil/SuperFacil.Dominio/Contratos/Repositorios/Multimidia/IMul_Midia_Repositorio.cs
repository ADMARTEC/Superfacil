﻿using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
    {
    public interface IMul_Midia_Repositorio : IDisposable
        {

        #region SELECT - R
        Task<Mul_Midia> GetByID(int Empresa, int value);
        Task<Mul_Midia> GetByParent(int Empresa, int value);
        Task<Mul_Midia> GetByFixa(int Empresa, int value);
        Task<Mul_Midia> GetByDesiginacao(int Empresa, string value);
        Task<Mul_Midia> GetByAutor(int Empresa, int value);
        Task<Mul_Midia> GetByTag(int Empresa, string value);
        Task<Mul_Midia> GetByLocalizacao(int Empresa, int value);
        Task<Mul_Midia> GetByAno_Lancamento(int Empresa, DateTime value); 
        #endregion

        #region CUD
        void Create(Mul_Midia midia);
        void Update(Mul_Midia midia);
        void Deleted(Mul_Midia midia);
        #endregion
        }
    }
