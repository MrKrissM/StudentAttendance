using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using StudentAttendance.Models;

namespace StudentAttendance.Data;

public class StudentAttendanceContext : DbContext {

    public StudentAttendanceContext(DbContextOptions<StudentAttendanceContext> options): base(options){

    }

    public DbSet<Student> Students {get; set;}
    public  DbSet<Attendance> Attendances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
        .HasMany(s =>s.Attendances)
        .WithOne(a => a.Student)
        .HasForeignKey(b => b.StudentId);
    }




}