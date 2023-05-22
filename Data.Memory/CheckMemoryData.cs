using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Data.Memory
{
    public class CheckMemoryData : IData<ICheck>
    {
        private readonly List<ICheck> _checks;
        public CheckMemoryData()
        {
            _checks = new List<ICheck>();
        }
        public void Add(ICheck item)
        {
            _checks.Add(item);
        }

        public IEnumerable<ICheck> ReadAll()
        {
            return _checks;
        }

        public void Remove(ICheck item)
        {
            _checks.Remove(item);
        }
    }
}
