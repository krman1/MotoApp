using MotoApp.Repositories;
using MotoApp.Entities;

var employseeRepository = new GenericRepository<Employee, int>();
employseeRepository.Add(new Employee { FirstName = "Adam" });
employseeRepository.Add(new Employee { FirstName = "Piotr" });
employseeRepository.Add(new Employee { FirstName = "Zuzia" });
employseeRepository.Save();