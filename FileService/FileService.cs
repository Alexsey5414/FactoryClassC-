using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BaseServiceApp;

namespace ConsoleApp1.FileServiceApp
{
    public class FileService : BaseService, IFileService
    {
        public string GetNameService() => this.GetType().Name;
    }
}
