﻿using System.Text;
namespace MotoApp.Entities;

    public class Car : EntitesBase
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Type { get; set; }

        //Calculated propertis 

        public int? NameLenght { get; set; }
        public decimal? TotalSales { get; set; }

        //#region ToString Override
        public override string ToString()
        {
            StringBuilder sb = new(1024);

            sb.AppendLine($"{Name}  ID:{Id}");
            sb.AppendLine($" Color: {Color}   Type: {(Type ?? "n/a")}");
            sb.AppendLine($" Cost: {StandardCost:c} Prize: {ListPrice:c}");
            if (NameLenght.HasValue)
            {
                sb.AppendLine($" Name Lenght: {NameLenght}");
            }
            if (NameLenght.HasValue)
            {
                sb.AppendLine($" Total Sales: {TotalSales:c}");
            }
            return sb.ToString();
        }

    }