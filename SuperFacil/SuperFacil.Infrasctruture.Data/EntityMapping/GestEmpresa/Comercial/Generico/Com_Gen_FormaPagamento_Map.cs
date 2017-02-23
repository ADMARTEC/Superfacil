﻿using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Generico;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Generico
{
    public class Com_Gen_FormaPagamento_Map : EntityTypeConfiguration<Com_Gen_FormaPagamento>
    {
        public Com_Gen_FormaPagamento_Map()
        {
            this.HasKey(x => x.FormasPagamento_ID);

            Property(x => x.FormasPagamento_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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
