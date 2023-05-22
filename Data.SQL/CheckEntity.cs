using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SQL
{
    public class CheckEntity : ICheck
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string ToyName { get; set; }
        public IShop Shop { get; set; }
        public IToy Toy { get; set; }
        public DateTime DateTime { get; set; }

        public CheckEntity() { }

        public CheckEntity(ICheck item)
        {
            Id = 0;
            Shop = item.Shop;
            ShopName = item.Shop.Name;
            Toy = item.Toy;
            ToyName = item.Toy.Name;
            DateTime = item.DateTime;
        }

        public override string ToString()
        {
            return DateTime.ToString();
        }
    }
}
