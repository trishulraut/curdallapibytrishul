using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace namdemocoreapi.Models
{
    public partial class mitrozassigmentContext : DbContext
    {
        public mitrozassigmentContext()
        {
        }

        public mitrozassigmentContext(DbContextOptions<mitrozassigmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDeparment> TblDeparment { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GUKF4BP; Database=mitrozassigment; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDeparment>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("DEPT_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EId);

                entity.Property(e => e.EId).HasColumnName("E_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("Mobile_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
