namespace MotoApp.Entities
{
    public class Car : EntitesBase
    {
        public string Name {  get; set; }
        public string Color { get; set; }
        public decimal StndardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Type { get; set; }    

        //Calculated propertis 

        public int? NameLenght { get; set; }
        public decimal TotalSales { get; set; }
    }
}
