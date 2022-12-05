using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace db.Models;

public partial class GestionAhorrosContext : DbContext
{
    public GestionAhorrosContext()
    {
    }

    public GestionAhorrosContext(DbContextOptions<GestionAhorrosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=gestion_ahorros;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__movimien__3213E83FAB87AA05");

            entity.ToTable("movimientos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Destino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("destino");
            entity.Property(e => e.Emisor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("emisor");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.MedioPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("medio_pago");
            entity.Property(e => e.Tipo)
                .HasColumnType("text")
                .HasColumnName("tipo");
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo_detalle");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__movimient__id_us__276EDEB3");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83FFFA1F5B7");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Mail, "UQ__usuarios__7A212904CB0E3490").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BalanceDolar).HasColumnName("balance_dolar");
            entity.Property(e => e.BalancePesos).HasColumnName("balance_pesos");
            entity.Property(e => e.DateJoined)
                .HasColumnType("datetime")
                .HasColumnName("date_joined");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Mail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
