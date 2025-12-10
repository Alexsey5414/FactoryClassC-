using ConsoleApp1.BaseServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FileServiceApp
{
    public class FTPService : BaseService, IFTPService
    {
        public string GetNameService() => this.GetType().Name;
    }
}
