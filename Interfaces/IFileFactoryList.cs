using ConsoleApp1.FactoryStorage;
using ConsoleApp1.FileServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface IFileFactoryList: IFactoryTypeListStorage<FileFactory>
    {
    }
}
