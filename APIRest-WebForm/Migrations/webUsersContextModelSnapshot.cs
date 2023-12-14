﻿// <auto-generated />
using System;
using APIRest_WebForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIRest_WebForm.Migrations
{
    [DbContext(typeof(webUsersContext))]
    partial class webUsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APIRest_WebForm.Models.Persona", b =>
                {
                    b.Property<decimal>("Identificador")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("identificador");

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("email");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date")
                        .HasColumnName("fecha_creacion");

                    b.Property<string>("Nombre")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre");

                    b.Property<string>("NombreApellidos")
                        .HasMaxLength(130)
                        .IsUnicode(false)
                        .HasColumnType("varchar(130)")
                        .HasColumnName("nombre_apellidos");

                    b.Property<string>("NumeroIdentificacion")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("numero_identificacion");

                    b.Property<string>("TipoIdentificacion")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("tipo_identificacion");

                    b.Property<string>("TipoNumeroIdentificacion")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("tipo_numero_identificacion");

                    b.HasKey("Identificador")
                        .HasName("PK__PERSONAS__C83612B1C194EA99");

                    b.ToTable("PERSONAS", (string)null);
                });

            modelBuilder.Entity("APIRest_WebForm.Models.Usuario", b =>
                {
                    b.Property<decimal>("Identificador")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("identificador");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date")
                        .HasColumnName("fecha_creacion");

                    b.Property<string>("Pass")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pass");

                    b.Property<string>("Usuario1")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("usuario");

                    b.HasKey("Identificador")
                        .HasName("PK__USUARIO__C83612B1ACBA89BD");

                    b.ToTable("USUARIO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
