using Interfaces;

namespace Data.Memory
{
    public class ToyMemoryData : IData<IToy>
    {
        private readonly List<IToy> _toys;
        public ToyMemoryData()
        {
            _toys = new List<IToy>();
        }
        public void Add(IToy item)
        {
            _toys.Add(item);
        }

        public IEnumerable<IToy> ReadAll()
        {
            return _toys;
        }

        public void Remove(IToy item)
        {
            _toys.Remove(item);
        }
    }
}