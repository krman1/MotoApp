
using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Entities;
using MotoApp.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>();
app.Run();

/*using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories.Extentions;
using System.Runtime.CompilerServices;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
//employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

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


static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Marcin" },
        new Employee { FirstName = "Iwona" },
        new Employee { FirstName = "Mariusz" }
    };
    employeeRepository.AddBatch(employees);

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
    var data = repository.GetById(2);
  
        Console.WriteLine(data);
    
}
*/