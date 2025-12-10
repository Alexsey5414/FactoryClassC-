using ConsoleApp1.BaseServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryStorage
{
    public class CommonFactoryList: FactoryTypeListStorage<IBaseServiceFactory>, IFactoryTypeListStorage<IBaseServiceFactory>
    {
        public CommonFactoryList(IEnumerable<IBaseServiceFactory> factories) : base(factories) { }
       

    }
}
