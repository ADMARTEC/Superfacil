﻿using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Map : EntityTypeConfiguration<Fin_Banco>
    {
        public Fin_Banco_Map()
        {
            this.HasKey(x => x.Banco_ID);

            Property(x => x.Banco_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Parent_ID)
                .IsOptional();

            Property(x => x.Designacao)
                .IsRequired();

            Property(x => x.Morada)
                .IsRequired();

            Property(x => x.Activo)
                .IsRequired();

            Property(x => x.CreateUser)
               .IsRequired();

            Property(x => x.CreateDate)
               .IsRequired();

            Property(x => x.UpdateUser)
               .IsRequired();

            Property(x => x.UpdateDate)
               .IsRequired();

            Property(x => x.DeleteUser)
                .IsOptional();

            Property(x => x.DeleteDate)
                .IsOptional();

            Property(x => x.Deleted)
               .IsRequired();

            Property(x => x.DefaultSystem)
               .IsRequired();

        }    
    }
}
