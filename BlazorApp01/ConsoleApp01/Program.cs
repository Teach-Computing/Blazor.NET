using Bogus;
using ConsoleApp01.Data;
using Dumpify;

//StudentRepositoryInMemory db = new StudentRepositoryInMemory();
//var list = db.GetAllStudents();
//list.Dump();


var db = new StudentContext();

var std = new Faker<Student>()
                .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.RegistrationNo, f => $"EG/{f.Random.Int(2020, 2050)}/0{f.Random.Int(1000, 9999)}")
                .RuleFor(s => s.Id, Guid.NewGuid())
                .Generate();


db.Students.Add(std);
db.SaveChanges();