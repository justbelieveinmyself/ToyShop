using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Data.SQL
{
    public class ToyEntity : IToy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public ToyEntity() { }

        public ToyEntity(IToy item)
        {
            Id = 0;
            Name = item.Name;
            Manufacturer = item.Manufacturer;
            Price = item.Price;
        }

        public override string ToString()
        {
            return $"{Name} от {Manufacturer}";
        }
    }
}
