using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EF_DB_DEMO.Models
{
    public partial class HEXA_DBF_COREContext : DbContext
    {
        public HEXA_DBF_COREContext()
        {
        }

        public HEXA_DBF_COREContext(DbContextOptions<HEXA_DBF_COREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=10.3.117.39;Database=HEXA_DBF_CORE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
            entity.HasKey(e => e.EmpId)
                .HasName("PK__Employee__AF2DBB99AC27F87F");

            entity.ToTable("Employee");

            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
                

                //    entity.HasOne(d => d.Department)
                //        .WithMany(p => p.Employees)
                //        .HasForeignKey(d => d.DepartmentId)
                //        .HasConstraintName("FK__Employee__Depart__25869641");
                });

            OnModelCreatingPartial(modelBuilder);

        }
    

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
