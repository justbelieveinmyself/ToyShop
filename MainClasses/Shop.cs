using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Shop : IShop
    {
        private readonly IData<IToy> _toyData;
        private readonly IData<ICheck> _checkData;
        public string Name { get; set; }
        public string Adress { get; set; }
        public Shop(IData<IToy> toyData, IData<ICheck> checkData)
        {
            _toyData = toyData ?? throw new ArgumentNullException(nameof(toyData));
            _checkData = checkData ?? throw new ArgumentNullException(nameof(checkData));
        }
        public void Add(IToy toy)
        {
            _toyData.Add(toy);
        }

        public IEnumerable<IToy> GetAllToys()
        {
            return _toyData.ReadAll();
        }

        public ICheck Sell(IToy toy)
        {
            var check = new Check()
            {
                Toy = toy,
                Shop = this,
                DateTime = DateTime.Now
            };
            _toyData.Remove(toy);
            _checkData.Add(check);
            return check;
        }
    }
}
