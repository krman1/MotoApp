using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());

AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);


static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Adam" },
        new Employee { FirstName = "Piotr" },
        new Employee { FirstName = "Zuzia" }
    };
    AddBatch(employeeRepository, employees);

    /*employeeRepository.Add(new Employee { FirstName = "Adam" });
    employeeRepository.Add(new Employee { FirstName = "Piotr" });
    employeeRepository.Add(new Employee { FirstName = "Zuzia" });
    employeeRepository.Save();*/
}

static void AddBatch<T>(IRepository<T> repository, T[] items)
    where T : class, IEntity
{
    foreach (var item in items)
    {
        repository.Add(item);
    }
    repository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}