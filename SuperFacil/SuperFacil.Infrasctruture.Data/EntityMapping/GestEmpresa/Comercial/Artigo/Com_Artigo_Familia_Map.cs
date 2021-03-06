﻿using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo_Familia_Map : EntityTypeConfiguration<Com_Artigo_Familia>
    {
        public Com_Artigo_Familia_Map()
        {
            this.HasKey(x => x.Familia_ID);

            Property(x => x.Familia_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Parente_ID)
                .IsOptional();

            Property(x => x.Designacao)
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
