using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SQL
{
    public class CheckSQLData : IData<ICheck>
    {
        public void Add(ICheck item)
        {
            using (var db = new ToyShopDbContext())
            {
                var check = new CheckEntity(item);
                db.Checks.Add(check);
                db.SaveChanges();
            }
        }
        public IEnumerable<ICheck> ReadAll()
        {
            using (var db = new ToyShopDbContext())
            {
                return db.Checks.ToList();
            }
        }
        public void Remove(ICheck item)
        {
            using (var db = new ToyShopDbContext())
            {
                var check = new CheckEntity(item);
                db.Checks.Remove(check);
                db.SaveChanges();
            }
        }
    }
}
