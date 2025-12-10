using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaseServiceApp
{
    public class FactoryListStorage : IFactoryListStorage
    {
        private readonly List<IBaseServiceFactory> _serviceFactories;
        public List<IBaseServiceFactory> serviceFactories { get => _serviceFactories.ToList(); }
        public IBaseServiceFactory GetFactory<T>() => _serviceFactories.FirstOrDefault(factory => factory.GetTypeFactory() == typeof(T)); 
        public FactoryListStorage(IEnumerable<IBaseServiceFactory> serviceFactories)
        {
            _serviceFactories = serviceFactories.ToList();
        }
    }
}
