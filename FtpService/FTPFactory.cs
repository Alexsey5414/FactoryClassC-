using ConsoleApp1.BaseServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FileServiceApp
{
    public class FTPFactory : BaseServiceFactory<FTPService>
    {
       public FTPFactory(ServiceCreator<FTPService> serviceCreator)
        {
            this.serviceCreator = serviceCreator;
            this.Name = "FTPFactoryName";
        }
    }
}
