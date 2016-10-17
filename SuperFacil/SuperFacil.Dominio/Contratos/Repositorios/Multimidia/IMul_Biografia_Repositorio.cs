﻿using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
    {
    public interface IMul_Biografia_Repositorio : IDisposable
        {
        #region SELECT - R
        Task<Mul_Biografia> GetByID(int Empresa, int value);
        Task<Mul_Biografia> GetByAutor_ID(int Empresa, int value);
        Task<Mul_Biografia> GetByDesiginacao(int Empresa, string value);
        #endregion

        #region CUD
        void Create(Mul_Biografia biografia);
        void Update(Mul_Biografia biografia);
        void Deleted(Mul_Biografia biografia);
        #endregion
        }
    }