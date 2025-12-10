using System.Collections.Generic;

namespace ConsoleApp1.BaseServiceApp
{
    public interface IFactoryListStorage
    {
        List<IBaseServiceFactory> serviceFactories { get; }
        IBaseServiceFactory GetFactory<T>();
    }
}