using ProManager.BL.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Net;

namespace ProManager.BL.Data
{
    public class ProManagerContext : DbContext
    {

        private static ProManagerContext proManagerContext = null;

        public ProManagerContext()
            : base("ProManagerContext")
        {
        }

        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }

        public static ProManagerContext Create()
        {
            if (proManagerContext == null)
            {
                proManagerContext = new ProManagerContext();
            }
            return proManagerContext;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.ruc)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.web)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Contacto)
                .WithOptional(e => e.Empresa)
                .HasForeignKey(e => e.empresa_id);
        }
    }
}
