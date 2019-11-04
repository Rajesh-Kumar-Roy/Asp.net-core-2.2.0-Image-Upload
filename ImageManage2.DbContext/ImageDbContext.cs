using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageManage2.DbContext
{
    public class ImageDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public ImageDbContext()
        {
            
        }
        public ImageDbContext(DbContextOptions db):base(db)
        {
           
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ImageMange2Db;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(c => c.Id);
            modelBuilder.Entity<Employee>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Employee>().Property(c => c.Name).IsRequired();

            modelBuilder.Entity<Employee>().HasOne(c => c.Department)
                .WithMany(d => d.Employee)
                .HasForeignKey(d => d.DepartmentId).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
