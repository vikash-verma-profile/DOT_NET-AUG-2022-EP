using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day_11.Models
{
    public partial class DemoDBContext : DbContext
    {
        public DemoDBContext()
        {
        }

        public DemoDBContext(DbContextOptions<DemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSubject> CourseSubjects { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DemoP> DemoPs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dummy> Dummies { get; set; }
        public virtual DbSet<Dummy1> Dummy1s { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Sample2> Sample2s { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblStudent> TblStudents { get; set; }
        public virtual DbSet<Tbldummy> Tbldummies { get; set; }
        public virtual DbSet<Tblsample> Tblsamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=DemoDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseSubject>(entity =>
            {
                entity.ToTable("CourseSubject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSubjects)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__CourseSub__Cours__45F365D3");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemoP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemoP");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SumValue).HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dummy1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy1");

                entity.HasIndex(e => e.Id, "UQ__dummy1__3213E83EC59155CE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FinalAmount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("MRP");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Productname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("productname");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sample");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sample2>(entity =>
            {
                entity.ToTable("sample2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__student__CourseI__403A8C7D");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tblOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CutomerId).HasColumnName("CutomerID");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cutomer)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.CutomerId)
                    .HasConstraintName("FK__tblOrder__Cutome__3B75D760");
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.ToTable("tblStudent");

                entity.HasIndex(e => e.Name, "UQ__tblStude__737584F6921C3B82")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbldummy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('vikash')");
            });

            modelBuilder.Entity<Tblsample>(entity =>
            {
                entity.ToTable("tblsample");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
