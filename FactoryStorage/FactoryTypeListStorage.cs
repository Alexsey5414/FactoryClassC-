using ConsoleApp1.BaseServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryStorage
{
    public class FactoryTypeListStorage<T> : List<T>, IFactoryTypeListStorage<T> where T : IBaseServiceFactory
    {
        public T GetFactory() => this.Find(factory => factory is T);
        public T GetFactory<Y>() => this.Find(factory => factory is Y);//factory.GetTypeFactory() == typeof(Y));
        public FactoryTypeListStorage(IEnumerable<T> serviceFactories)
        {
            this.AddRange(serviceFactories);
        }
    }
}
