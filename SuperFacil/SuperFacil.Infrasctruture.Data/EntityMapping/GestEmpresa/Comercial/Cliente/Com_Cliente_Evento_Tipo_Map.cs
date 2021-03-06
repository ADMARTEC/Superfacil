﻿using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Evento_Tipo_Map : EntityTypeConfiguration<Com_Cliente_Evento_Tipo>
    {
        public Com_Cliente_Evento_Tipo_Map()
        {
            this.HasKey(x => x.Evento_Tipo_ID);

            Property(x => x.Evento_Tipo_ID)
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
