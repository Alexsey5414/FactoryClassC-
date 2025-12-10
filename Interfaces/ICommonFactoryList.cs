using ConsoleApp1.BaseServiceApp;
using ConsoleApp1.FactoryStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface ICommonFactoryList: IFactoryTypeListStorage<IBaseServiceFactory>
    {
    }
}
