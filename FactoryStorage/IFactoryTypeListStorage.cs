using ConsoleApp1.BaseServiceApp;

namespace ConsoleApp1.FactoryStorage
{
    public interface IFactoryTypeListStorage<T> where T : IBaseServiceFactory
    {
        T GetFactory();
    }
}