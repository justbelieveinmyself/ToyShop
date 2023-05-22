using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Data.SQL
{
    public class ToySQLData : IData<IToy>
    {
        public void Add(IToy item)
        {
            using (var db = new ToyShopDbContext())
            {
                var book = new ToyEntity(item);
                db.Toys.Add(book);
                db.SaveChanges();
            }
        }

        public IEnumerable<IToy> ReadAll()
        {
            using (var db = new ToyShopDbContext())
            {
                return db.Toys.ToList();
            }
        }

        public void Remove(IToy item)
        {
            using (var db = new ToyShopDbContext())
            {
                var toy = db.Toys.SingleOrDefault(b => b.Manufacturer.Equals(item.Manufacturer) &&
                    b.Name.Equals(item.Name) &&
                    b.Price.Equals(item.Price));
                db.Toys.Remove(toy);
                db.SaveChanges();
            }
        }
    }
}
