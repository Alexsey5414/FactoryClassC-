using ConsoleApp1.BaseServiceApp;

namespace ConsoleApp1.FactoryStorage
{
    public interface IFactoryTypeListStorage<out T> where T : IBaseServiceFactory
    {
        T GetFactory();
    }
}