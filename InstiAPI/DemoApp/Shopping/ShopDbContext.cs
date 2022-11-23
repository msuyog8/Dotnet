global using Microsoft.EntityFrameworkCore;

namespace DemoApp.Shopping;
public class ShopDbContext : DbContext
{
    public DbSet<NewCourse> NewCourses { get; set; }

    public DbSet<NewStudent> NewStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DACIIT;Database=Institute");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NewCourse>()
            .ToTable("Course") //  database table name
            .Property(p => p.Id)
            .HasColumnName("CourseName"); // 1st column  name in database

        modelBuilder.Entity<NewStudent>()
            .ToTable("Student")
            .Property(p => p.Id)
            .HasColumnName("RollNo"); // 1st column name in database
        modelBuilder.Entity<NewStudent>() // FK mapping here 
            .Property(p => p.NewCourseId)
            .HasColumnName("CourseName"); // 4th column name in database which is a fk
        
    }
}