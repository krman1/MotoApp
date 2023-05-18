namespace MotoApp.Entities
{
    public class Employee : EntitesBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, Firstname: {FirstName}";
    }
}
    