using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShop
    {
        string Name { get; set; }
        string Adress { get;set; }
        void Add(IToy toy);
        IEnumerable<IToy> GetAllToys();
        ICheck Sell(IToy toy);

    }
}
