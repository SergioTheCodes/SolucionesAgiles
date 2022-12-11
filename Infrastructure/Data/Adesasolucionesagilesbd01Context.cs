using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class Adesasolucionesagilesbd01Context : DbContext
{
    public Adesasolucionesagilesbd01Context()
    {
    }

    public Adesasolucionesagilesbd01Context(DbContextOptions<Adesasolucionesagilesbd01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cancelacion> Cancelacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=adesasolucionesagilesbd01;Username=postgres;Password=dbpassword", x => x.UseNetTopologySuite());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cancelacion>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cancelacion_pkey");

            entity.ToTable("cancelacion", "cancelacion");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .HasColumnName("ciudad");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(100)
                .HasColumnName("correo_cliente");
            entity.Property(e => e.EnviaCorreo)
                .HasMaxLength(200)
                .HasColumnName("envia_correo");
            entity.Property(e => e.FechaNotificacionInmediata).HasColumnName("fecha_notificacion_inmediata");
            entity.Property(e => e.FechaSeleccionCategoria).HasColumnName("fecha_seleccion_categoria");
            entity.Property(e => e.LineaProductoSolicitud).HasColumnName("linea_producto_solicitud");
            entity.Property(e => e.NumeroContacto).HasColumnName("numero_contacto");
            entity.Property(e => e.OtroCanal)
                .HasMaxLength(100)
                .HasColumnName("otro_canal");
            entity.Property(e => e.TipoContacto)
                .HasMaxLength(100)
                .HasColumnName("tipo_contacto");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(2000)
                .HasColumnName("tipologia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
