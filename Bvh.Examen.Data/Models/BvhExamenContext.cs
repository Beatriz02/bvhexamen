using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bvh.Examen.Data.Models
{
    public partial class BvhExamenContext : DbContext
    {
        public BvhExamenContext()
        {
        }

        public BvhExamenContext(DbContextOptions<BvhExamenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Notificacion> Notificacions { get; set; } = null!;
        public virtual DbSet<NotificacionApi> NotificacionApis { get; set; } = null!;
        public virtual DbSet<NotificacionEmail> NotificacionEmails { get; set; } = null!;
        public virtual DbSet<NotificacionPush> NotificacionPushes { get; set; } = null!;
        public virtual DbSet<NotificacionSm> NotificacionSms { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<TipoNotificacion> TipoNotificacions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=YTTEB\\SQLEXPRESS; Database=BvhExamen; User Id=sa; Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aMaterno");

                entity.Property(e => e.APaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aPaterno");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Privilegios).HasColumnName("privilegios");
            });

            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.ToTable("Notificacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DteFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dteFechaCreacion");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.IdTipoNotificacion).HasColumnName("idTipoNotificacion");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notificacion_Empleado");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.IdRegion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notificacion_Region");

                entity.HasOne(d => d.IdTipoNotificacionNavigation)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.IdTipoNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notificacion_TipoNotificacion");
            });

            modelBuilder.Entity<NotificacionApi>(entity =>
            {
                entity.ToTable("NotificacionApi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CampoLibre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("campoLibre");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdNotificacion).HasColumnName("idNotificacion");

                entity.Property(e => e.UrlApi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("urlApi");

                entity.HasOne(d => d.IdNotificacionNavigation)
                    .WithMany(p => p.NotificacionApis)
                    .HasForeignKey(d => d.IdNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificacionApi_Notificacion");
            });

            modelBuilder.Entity<NotificacionEmail>(entity =>
            {
                entity.ToTable("NotificacionEmail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Docto2Base64)
                    .IsUnicode(false)
                    .HasColumnName("docto2Base64");

                entity.Property(e => e.DoctoBase64)
                    .IsUnicode(false)
                    .HasColumnName("doctoBase64");

                entity.Property(e => e.IdNotificacion).HasColumnName("idNotificacion");

                entity.HasOne(d => d.IdNotificacionNavigation)
                    .WithMany(p => p.NotificacionEmails)
                    .HasForeignKey(d => d.IdNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificacionEmail_Notificacion");
            });

            modelBuilder.Entity<NotificacionPush>(entity =>
            {
                entity.ToTable("NotificacionPush");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdNotificacion).HasColumnName("idNotificacion");

                entity.HasOne(d => d.IdNotificacionNavigation)
                    .WithMany(p => p.NotificacionPushes)
                    .HasForeignKey(d => d.IdNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificacionPush_Notificacion");
            });

            modelBuilder.Entity<NotificacionSm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdNotificacion).HasColumnName("idNotificacion");

                entity.HasOne(d => d.IdNotificacionNavigation)
                    .WithMany(p => p.NotificacionSms)
                    .HasForeignKey(d => d.IdNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificacionSms_Notificacion");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TipoNotificacion>(entity =>
            {
                entity.ToTable("TipoNotificacion");

                entity.HasIndex(e => e.Id, "IX_TipoNotificacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aMaterno");

                entity.Property(e => e.APaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aPaterno");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRegion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Region");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
