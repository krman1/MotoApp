using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;

/*var employseeRepository = new GenericRepository<Employee>();
employseeRepository.Add(new Employee { FirstName = "Adam" });
employseeRepository.Add(new Employee { FirstName = "Piotr" });
employseeRepository.Add(new Employee { FirstName = "Zuzia" });
employseeRepository.Save();*/

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee { FirstName = "Adam" });
sqlRepository.Add(new Employee { FirstName = "Piotr" });
sqlRepository.Add(new Employee { FirstName = "Zuzia" });
sqlRepository.Save();
var emp = sqlRepository.GetById(1);
Console.WriteLine(emp.ToString());