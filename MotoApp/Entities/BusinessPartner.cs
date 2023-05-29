namespace MotoApp.Entities
{
    public class BusinessPartner : EntitesBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
        
    }
}
