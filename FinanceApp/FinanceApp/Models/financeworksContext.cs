using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinanceApp.Models
{
    public partial class financeworksContext : DbContext
    {
        public financeworksContext()
        {
        }

        public financeworksContext(DbContextOptions<financeworksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fund> Funds { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
                optionsBuilder.UseMySQL(Configuration.GetConnectionString("server=localhost;port=3306;database=financeworks;user=root;password=Laserpn7;"));


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fund>(entity =>
            {
                entity.HasKey(e => e.IdFunds)
                    .HasName("PRIMARY");

                entity.ToTable("funds");

                entity.Property(e => e.IdFunds).HasColumnName("idFunds");

                entity.Property(e => e.Cash).HasColumnName("cash");

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.Savings).HasColumnName("savings");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionSet)
                    .HasName("PRIMARY");

                entity.ToTable("transactions");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.Type).HasMaxLength(45);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .HasColumnName("lastName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
