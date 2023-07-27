using System.Globalization;

namespace MotoApp.Entities
{
    public class Employee : EntitesBase
    {
        public string? FirstName { get; set; }
        /*public Employee(string FirstName) 
        {
            this.FirstName = FirstName;
        }*/
   
        public override string ToString() => $"Id: {Id}, Firstname: {FirstName}";
    }
}
    