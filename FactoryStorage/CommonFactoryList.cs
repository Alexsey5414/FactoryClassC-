using ConsoleApp1.BaseServiceApp;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryStorage
{
    public class CommonFactoryList: FactoryTypeListStorage<IBaseServiceFactory>, ICommonFactoryList
    {
        public CommonFactoryList(IEnumerable<IBaseServiceFactory> factories) : base(factories) { }
       

    }
}
