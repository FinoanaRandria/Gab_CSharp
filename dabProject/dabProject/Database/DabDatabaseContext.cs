using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dabProject.Database
{
    public partial class DabDatabaseContext : DbContext
    {
        public DabDatabaseContext()
        {
        }

        public DabDatabaseContext(DbContextOptions<DabDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=DESKTOP-9AU0B3O\\SQLEXPRESS;initial catalog=DabDatabase;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CarteNumber)
                    .HasMaxLength(16)
                    .HasColumnName("Carte_number")
                    .IsFixedLength();

                entity.Property(e => e.Creation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expiration)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasMaxLength(4)
                    .HasColumnName("PIN")
                    .IsFixedLength();

                entity.Property(e => e.Tentative).HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClentId);

                entity.ToTable("Client");

                entity.Property(e => e.ClentId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClentID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cin)
                    .HasMaxLength(16)
                    .HasColumnName("CIN")
                    .IsFixedLength();

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
