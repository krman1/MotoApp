using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories.Extentions;
using System.Runtime.CompilerServices;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

static void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
{
    Console.WriteLine($"Employee added => {e.FirstName} from {sender?.GetType().Name}");
}

AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);
WriteById(employeeRepository);

static void EmployeeAdded(Employee item)
{
    Console.WriteLine($"{item.FirstName} added");
}


/*static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Adam1" },
        new Employee { FirstName = "Janusz2" },
        new Employee { FirstName = "Ewa3" }
    };
    employeeRepository.AddBatch(employees);

}*/

static void AddEmployees(IWriteRepository<Employee> employeeRepository)
{

    employeeRepository.Add(new Employee { FirstName = "Nowy Adam" });
    employeeRepository.Add(new Employee { FirstName = "Nowa Ewa" });
    employeeRepository.Add(new Employee { FirstName = "Nowy Marcin" });

}


static void WriteAllToConsole(IReadRepository<IEntity> employeeRepository)
{
    var items = employeeRepository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

static void WriteById(IReadRepository<IEntity> repository)
{
    var data = repository.GetById(1);
  
        Console.WriteLine(data);
    
}