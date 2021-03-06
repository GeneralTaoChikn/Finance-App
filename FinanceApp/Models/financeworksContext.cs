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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;port=3306;database=financeworks;user=root;password=Laserpn7;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fund>(entity =>
            {
                entity.HasKey(e => e.FundsId)
                    .HasName("PRIMARY");

                entity.ToTable("funds");

                entity.Property(e => e.FundsId)
                    .HasMaxLength(36)
                    .HasColumnName("FundsID")
                    .IsFixedLength(true);

                entity.Property(e => e.Cash).HasColumnName("cash");

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.Savings).HasColumnName("savings");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("userID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(36)
                    .HasColumnName("TransactionID")
                    .IsFixedLength(true);

                entity.Property(e => e.Type).HasMaxLength(45);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("userID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .IsFixedLength(true);

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
