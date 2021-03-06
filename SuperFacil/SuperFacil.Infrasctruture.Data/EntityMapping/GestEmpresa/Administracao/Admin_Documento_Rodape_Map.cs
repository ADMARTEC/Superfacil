﻿using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Administracao
{
    public class Admin_Documento_Rodape_Map : EntityTypeConfiguration<Admin_Documento_Rodape>
    {
        public Admin_Documento_Rodape_Map()
        {
            this.HasKey(x => x.Documento_Rodape_ID);

            Property(x => x.Documento_Rodape_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Documento_ID)
                .IsRequired();

            Property(x => x.Designacao)
                .IsRequired();

            Property(x => x.Numero_Linha)
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
