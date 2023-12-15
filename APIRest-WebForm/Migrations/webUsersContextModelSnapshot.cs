﻿// <auto-generated />
using System;
using APIRest_WebForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace APIRestWebForm.Migrations
{
    [DbContext(typeof(webUsersContext))]
    partial class webUsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("APIRest_WebForm.Models.Persona", b =>
                {
                    b.Property<Guid>("Identificador")
                        .HasColumnType("uuid")
                        .HasColumnName("identificador");

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("email");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date")
                        .HasColumnName("fecha_creacion");

                    b.Property<string>("Nombre")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("nombre");

                    b.Property<string>("NombreApellidos")
                        .HasMaxLength(130)
                        .IsUnicode(false)
                        .HasColumnType("character varying(130)")
                        .HasColumnName("nombre_apellidos");

                    b.Property<string>("NumeroIdentificacion")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("numero_identificacion");

                    b.Property<string>("TipoIdentificacion")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("tipo_identificacion");

                    b.Property<string>("TipoNumeroIdentificacion")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("tipo_numero_identificacion");

                    b.HasKey("Identificador")
                        .HasName("PK__PERSONAS__C83612B1B64D74CB");

                    b.ToTable("PERSONAS", (string)null);
                });

            modelBuilder.Entity("APIRest_WebForm.Models.Usuario", b =>
                {
                    b.Property<Guid>("Identificador")
                        .HasColumnType("uuid")
                        .HasColumnName("identificador");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date")
                        .HasColumnName("fecha_creacion");

                    b.Property<string>("Pass")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("pass");

                    b.Property<string>("Usuario1")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("usuario");

                    b.HasKey("Identificador")
                        .HasName("PK__USUARIO__C83612B124CA4351");

                    b.ToTable("USUARIO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
