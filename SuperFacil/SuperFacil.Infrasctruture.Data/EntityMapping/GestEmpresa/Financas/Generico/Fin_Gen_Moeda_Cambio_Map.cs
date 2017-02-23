﻿using SuperFacil.Domain.Entities.GestEmpresa.Financas.Generico;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Financas.Generico
{
    public class Fin_Gen_Moeda_Cambio_Map : EntityTypeConfiguration<Fin_Gen_Moeda_Cambio>
    {
        public Fin_Gen_Moeda_Cambio_Map()
        {
            this.HasKey(x => x.Cambio_ID);

            Property(x => x.Cambio_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Moeda_ID)
                .IsRequired();

            Property(x => x.Valor)
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
