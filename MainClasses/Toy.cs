using Interfaces;
namespace MainClasses
{
    public class Toy : IToy
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Название: {Name}, От {Manufacturer}. Цена - {Price}";
        }
    }
}