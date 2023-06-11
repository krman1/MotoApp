using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });

GetEmployeeById(employeeRepository);

static void GetEmployeeById (IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(1);
    Console.WriteLine(employee.ToString());

}

