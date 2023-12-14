using System;
using System.Collections.Generic;
using APIRest_WebForm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIRest_WebForm.Data
{
    public partial class webUsersContext : DbContext
    {
        public webUsersContext()
        {
        }

        public webUsersContext(DbContextOptions<webUsersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS; database=webUsers; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("PK__PERSONAS__C83612B1C194EA99");

                entity.ToTable("PERSONAS");

                entity.Property(e => e.Identificador)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("identificador");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreApellidos)
                    .HasMaxLength(130)
                    .IsUnicode(false)
                    .HasColumnName("nombre_apellidos");

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_identificacion");

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tipo_identificacion");

                entity.Property(e => e.TipoNumeroIdentificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipo_numero_identificacion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("PK__USUARIO__C83612B1ACBA89BD");

                entity.ToTable("USUARIO");

                entity.Property(e => e.Identificador)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("identificador");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Pass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
