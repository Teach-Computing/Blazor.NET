using Bogus;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp02.Data;

public class StudentContext : DbContext
{
    
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"DataSource=C:\rajitha\teaching\ee4355\src\Blazor.NET\Blazor.NET\BlazorApp01\BlazorApp02\students.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(

            Enumerable.Range(0, 10).Select(_ =>

              new Faker<Student>()
                .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.RegistrationNo, f => $"EG/{f.Random.Int(2020, 2050)}/0{f.Random.Int(1000, 9999)}")
                .RuleFor(s => s.Id, Guid.NewGuid())
                .Generate()

            )
        );
    }
}
