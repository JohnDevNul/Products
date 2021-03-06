using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Models
{
    public class ProductModelDAO2
    {
        [DisplayName("Id number")]
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string PriceString { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public decimal Tax { get; set; }

        public ProductModelDAO2(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.08M;

        }

        public ProductModelDAO2(ProductModelDAO p)
        {
            Id = p.Id;
            Name = p.Name;
            Price = p.Price;
            Description = p.Description;

            PriceString = string.Format("{0:C}", p.Price);
            ShortDescription = p.Description.Length <= 25 ? p.Description : p.Description.Substring(0, 25);
            Tax = p.Price * 0.08M;

        }
    }
}
