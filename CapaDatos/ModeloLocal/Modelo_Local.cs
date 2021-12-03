using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos.ModeloLocal
{
    public partial class Modelo_Local : DbContext
    {
        public Modelo_Local()
            : base("name=Modelo_Local")
        {
        }

        public virtual DbSet<Cierres> Cierres { get; set; }
        public virtual DbSet<Ganadores> Ganadores { get; set; }
        public virtual DbSet<Ganadores_Diarios> Ganadores_Diarios { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Jugada> Jugada { get; set; }
        public virtual DbSet<Jugada_Temporal> Jugada_Temporal { get; set; }
        public virtual DbSet<Limite> Limite { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Valor_Premios> Valor_Premios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cierres>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Cierres>()
                .Property(e => e.Banca)
                .IsUnicode(false);

            modelBuilder.Entity<Cierres>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cierres>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores>()
                .Property(e => e.Loteria)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Loteria)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Tipo_Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Banca)
                .IsUnicode(false);

            modelBuilder.Entity<Ganadores_Diarios>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Horarios>()
                .Property(e => e.Loteria)
                .IsUnicode(false);

            modelBuilder.Entity<Horarios>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Horarios>()
                .Property(e => e.Tanda)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Numero_Ticket)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Loteria)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Tipo_Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Jugada1)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Tanda)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Banca)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada_Temporal>()
                .Property(e => e.Loteria)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada_Temporal>()
                .Property(e => e.Tipo_Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada_Temporal>()
                .Property(e => e.Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Jugada_Temporal>()
                .Property(e => e.Sub_Jugada)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Banca)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Acceso)
                .IsUnicode(false);

            modelBuilder.Entity<Valor_Premios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
