using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace practica14.Models;

public partial class MvccrudContext : DbContext
{
    public MvccrudContext()
    {
    }

    public MvccrudContext(DbContextOptions<MvccrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.ClienteId)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .HasColumnName("apellido");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .HasColumnName("ciudad");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleVentaId).HasName("PRIMARY");

            entity.ToTable("detalle_venta");

            entity.HasIndex(e => e.ProductoId, "producto_id");

            entity.HasIndex(e => e.VentaId, "venta_id");

            entity.Property(e => e.DetalleVentaId)
                .HasColumnType("int(11)")
                .HasColumnName("detalle_venta_id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(10, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.ProductoId)
                .HasColumnType("int(11)")
                .HasColumnName("producto_id");
            entity.Property(e => e.Subtotal)
                .HasPrecision(10, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.VentaId)
                .HasColumnType("int(11)")
                .HasColumnName("venta_id");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("detalle_venta_ibfk_2");

            entity.HasOne(d => d.Venta).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("detalle_venta_ibfk_1");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.Inventario)
                .HasColumnType("int(11)")
                .HasColumnName("inventario");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .HasColumnName("marca");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .HasColumnName("clave");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PRIMARY");

            entity.ToTable("ventas");

            entity.HasIndex(e => e.ClienteId, "cliente_id");

            entity.Property(e => e.VentaId)
                .HasColumnType("int(11)")
                .HasColumnName("venta_id");
            entity.Property(e => e.ClienteId)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_id");
            entity.Property(e => e.FechaVenta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_venta");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.TotalVenta)
                .HasPrecision(10, 2)
                .HasColumnName("total_venta");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(100)
                .HasColumnName("vendedor");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Venta)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("ventas_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
