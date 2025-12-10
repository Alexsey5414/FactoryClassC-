using ConsoleApp1.FileServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryStorage
{
    public class FTPFactoryList : FactoryTypeListStorage<FTPFactory>, IFactoryTypeListStorage<FTPFactory>
    {
        public FTPFactoryList(IEnumerable<FTPFactory> factories) : base(factories) { }


    }
}
