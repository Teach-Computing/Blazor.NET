using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01.Data
{
    public class StudentRepositoryInMemory
    {
        public  List<Student> GetAllStudents()
        {
            var list = Enumerable.Range(0, 10).Select( _ => 
            
              new Faker<Student>()
                .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.Email, (f,u) => f.Internet.Email(u.FirstName,u.LastName))
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.RegistrationNo, f => $"EG/{f.Random.Int(2020, 2050)}/0{f.Random.Int(1000, 9999)}") 
                .RuleFor(s => s.Id, Guid.NewGuid())
                .Generate()
                
            ).ToList();

            return list;
        }
    }
}
