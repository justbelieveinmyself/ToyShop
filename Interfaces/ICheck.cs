using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICheck
    {
        IShop Shop { get; set; }
        IToy Toy { get; set; }
        DateTime DateTime { get; set; }
    }
}
