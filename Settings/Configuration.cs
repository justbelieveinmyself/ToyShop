using Interfaces;
using Data.Memory;
using MainClasses;
using SimpleInjector;
using Data.SQL;
namespace Settings
{
    public class Configuration
    {
        public Container Container { get;}
        public Configuration()
        {
            Container = new Container();
            Setup();
        }
        public virtual void Setup()
        {
            Container.Register<IToy, Toy>(Lifestyle.Transient);
            Container.Register<ICheck, Check>(Lifestyle.Transient);
            Container.Register<IShop, Shop>(Lifestyle.Singleton);
            Container.Register<IData<IToy>, ToySQLData>(Lifestyle.Singleton);
            Container.Register<IData<ICheck>, CheckSQLData>(Lifestyle.Singleton);
            //Container.Register<IData<IToy>, ToyMemoryData>(Lifestyle.Singleton);
            //Container.Register<IData<ICheck>, CheckMemoryData>(Lifestyle.Singleton);
        }
    }
}