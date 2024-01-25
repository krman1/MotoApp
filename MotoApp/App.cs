using MotoApp.Entities;
using MotoApp.Repositories;

namespace MotoApp
{
    public class App : IApp
    {
        private readonly IRepository<Employee> _employeeRepository;

        public App(IRepository<Employee> employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }
        public void Run()
        {
            Console.WriteLine("I'm here in Run() method");

            var employees = new[]
        {
            new Employee { FirstName = "Marcin" },
            new Employee { FirstName = "Iwona" },
            new Employee { FirstName = "Mariusz" }
        };
            foreach (var employee in employees)
            {
                _employeeRepository.Add(employee);
            }
            _employeeRepository.Save();


            var items = _employeeRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
