using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Check : ICheck
    {
        public IShop Shop { get; set; }
        public IToy Toy { get; set; }
        public DateTime DateTime { get; set; }
        public override string ToString()
        {
            return DateTime.ToString();
        }
    }
}
