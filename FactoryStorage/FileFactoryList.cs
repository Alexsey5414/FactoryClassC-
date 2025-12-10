using ConsoleApp1.BaseServiceApp;
using ConsoleApp1.FileServiceApp;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryStorage
{
    public class FileFactoryList : FactoryTypeListStorage<FileFactory>, IFileFactoryList
    {
        public FileFactoryList(IEnumerable<FileFactory> factories) : base(factories) { }


    }
}
