using ConsoleApp1.BaseServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FileServiceApp
{
    public class CommonFactory<T> : BaseServiceFactory<T>
    {
        public CommonFactory(ServiceCreator<T> serviceCreator)
        {
            this.serviceCreator = serviceCreator;
            this.Name = "CommonFactoryName";
        }
    }
}
